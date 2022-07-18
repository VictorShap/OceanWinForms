using System.Text;
using OceanLibrary.UI.IOceanInterfaces;
using OceanLibrary.Ocean.UI.Enums;
using OceanLibrary.Ocean.OceanInterfaces;
using OceanLibrary.Ocean;
using OceanWinForms.UI.OceanViewerInterfaces;
using OceanLibrary.Exceptions;
using OceanWinForms.Util;
using OceanWinForms.Controller;

namespace OceanWinForms.UI
{
    public class OceanViewer : IOceanViewer, IOceanLaunch
    {
        #region Consts
        private const int DefaultThreadDelay = 1500;
        #endregion

        #region Readonly
        private readonly IOceanView _ocean; // field for interacting with the ocean
        private readonly AutoResetEvent _autoResetEvent;
        private readonly FormGameField _gameField;
        private readonly GroupBoxOcean _groupBoxOcean;
        private readonly int _threadDelay;
        private readonly int _iterations;
        private readonly int _obstacles;
        private readonly int _predators;
        private readonly int _prey;
        #endregion

        #region Fields
        private bool _isDone;
        private bool _wasValidationMessage;
        #endregion

        #region Properties
        public AutoResetEvent AutoResetEvent { get => _autoResetEvent; }
        public bool IsDone { get => _isDone; }
        #endregion

        #region Ctors
        private OceanViewer()
        {
            _threadDelay = DefaultThreadDelay;
            _ocean = new Ocean(this);
        }

        private OceanViewer(string iterations, string obstacles, string predators, string prey) : this()
        {
            Int32.TryParse(iterations, out _iterations);
            Int32.TryParse(obstacles, out _obstacles);
            Int32.TryParse(predators, out _predators);
            Int32.TryParse(prey, out _prey);
        }

        private OceanViewer(AutoResetEvent autoResetEvent, string iterations, string obstacles, string predators, string prey) : this(iterations, obstacles, predators, prey)
        {
            _autoResetEvent = autoResetEvent;
        }

        private OceanViewer(FormGameField formGameField, AutoResetEvent autoResetEvent, string iterations, string obstacles, string predators, string prey) : this(autoResetEvent, iterations, obstacles, predators, prey)
        {
            _gameField = formGameField;

            System.Windows.Forms.Application.DoEvents();
        }

        public OceanViewer(FormGameField formGameField, AutoResetEvent autoResetEvent, int indexNumber, int topPositionForOcean, int leftPositionForOcean, string iterations, string obstacles, string predators, string prey) : this(formGameField, autoResetEvent, iterations, obstacles, predators, prey)
        {
            _groupBoxOcean = new GroupBoxOcean(indexNumber, _ocean.NumRows, _ocean.NumColumns);

            ChangeControls(
                () =>
                {
                    _gameField.Controls.Add(_groupBoxOcean.GroupBox);
                },
                _gameField
                );

            ChangeControls(
                () =>
                {
                    _groupBoxOcean.GroupBox.Location = new Point(leftPositionForOcean, topPositionForOcean);
                },
               _groupBoxOcean.GroupBox
                );
        }
        #endregion

        #region Methods

        #region Private methods
        private void DisplayStats()
        {
            ChangeControls(
                () =>
                {
                    _groupBoxOcean.LblNumberOfIterations.Text = "Iteration number: " + _ocean.CurrentIteration;
                },
              _groupBoxOcean.LblNumberOfIterations);

            ChangeControls(
                () =>
                {
                    _groupBoxOcean.LblNumberOfObstacles.Text = "Obstacles: " + _ocean.NumObstacles;
                },
             _groupBoxOcean.LblNumberOfObstacles);

            ChangeControls(
                () =>
                {
                    _groupBoxOcean.LblNumberOfPredators.Text = "Predators: " + _ocean.NumPredators;
                },
              _groupBoxOcean.LblNumberOfPredators);

            ChangeControls(
                () =>
                {
                    _groupBoxOcean.LblNumberOfPrey.Text = "Prey: " + _ocean.NumPrey;
                },
              _groupBoxOcean.LblNumberOfPrey);
        }

        private void DisplayCells()
        {
            ChangeControls(
              () =>
              {
                  _groupBoxOcean.TableLayoutPaneltOcean.Suspend();
              },
             _groupBoxOcean.TableLayoutPaneltOcean);

            try
            {
                for (int row = 0; row < _ocean.NumRows; row++)
                {
                    for (int column = 0; column < _ocean.NumColumns; column++)
                    {
                        if (_ocean[row, column] == null)
                        {
                            ChangeControls(
                            () =>
                              {
                                  _groupBoxOcean.TableLayoutPaneltOcean.Controls["lbl" + row + "" + column].Text = Ocean.DefaultCellImage.ToString();
                              },
                            _groupBoxOcean.TableLayoutPaneltOcean);

                        }
                        else
                        {
                            ChangeControls(
                            () =>
                              {
                                  _groupBoxOcean.TableLayoutPaneltOcean.Controls["lbl" + row + "" + column].Text = _ocean[row, column].Image.ToString();
                              },
                            _groupBoxOcean.TableLayoutPaneltOcean);
                        }
                    }
                }
            }
            catch (InvalidCoordinateException e)
            {
                MessageBox.Show(e.Message + ": \nX:" + e.X + "\n Y:" + e.Y);
            }

            if (_ocean.CurrentIteration == 1)
            {
                ChangeControls(
                    () =>
                    {
                        _groupBoxOcean.LblGameState.Text = "Running...";
                    },
                  _groupBoxOcean.LblGameState);

                ChangeControls(
                    () =>
                    {
                        _groupBoxOcean.TableLayoutPaneltOcean.Visible = true;
                    },
                    _groupBoxOcean.TableLayoutPaneltOcean);
            }

            ChangeControls(
              () =>
              {
                  _groupBoxOcean.TableLayoutPaneltOcean.Resume();
              },
              _groupBoxOcean.TableLayoutPaneltOcean);
        }

        #region Checking for illegal thread calls
        private void ChangeControls(Action action, Control control)
        {
            if (!control.IsDisposed)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(action);
                }
                else
                {
                    action();
                }
            }
        }
        #endregion

        #endregion

        #region Public Methods
        public void RequestValueAndAssign(out int numIterations, out int numObstacles, out int numPredators, out int numPrey)
        {
            numIterations = _iterations;
            numObstacles = _obstacles;
            numPredators = _predators;
            numPrey = _prey;
        }

        public void DisplayGameState(GameState gameState)
        {
            switch (gameState)
            {
                case GameState.Start:

                    ChangeControls(
                        () =>
                        {
                            _groupBoxOcean.LblGameState.Text = "Starting...";
                        },
                        _groupBoxOcean.LblGameState);

                    System.Windows.Forms.Application.DoEvents();

                    _autoResetEvent.Set();
                    _autoResetEvent.WaitOne();

                    break;

                case GameState.End:

                    ChangeControls(
                        () =>
                        {
                            _groupBoxOcean.LblGameState.Text = "Simulation has been ended";
                        },
                        _groupBoxOcean.LblGameState);

                    System.Windows.Forms.Application.DoEvents();

                    _isDone = true;

                    _autoResetEvent.Set();
                    _autoResetEvent.Dispose();

                    break;
            }
        }

        public void DisplayValidationMessage(bool wasFormatException)
        {
            if (!wasFormatException && !_wasValidationMessage)
            {
                MessageBox.Show("Invalid value, so it will be set to maximum possible value");
                _wasValidationMessage = true;
            }
            else if (!_wasValidationMessage)
            {
                MessageBox.Show("Invalid input, so the it will be set its default value");
            }
        }

        public void DisplayIteration()
        {
            DisplayCells();
            DisplayStats();

            System.Windows.Forms.Application.DoEvents();

            _autoResetEvent.Set();
            Thread.Sleep(_threadDelay);
            _autoResetEvent.WaitOne();
        }

        public Task Launch()
        {
            return new Task(() => _ocean.Run());
        }
        #endregion

        #endregion
    }
}
