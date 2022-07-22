using OceanLibrary.UI.IOceanInterfaces;
using OceanLibrary.Ocean.UI.Enums;
using OceanLibrary.Ocean.OceanInterfaces;
using OceanLibrary.Ocean;
using OceanWinForms.UI.OceanViewerInterfaces;
using OceanLibrary.Exceptions;
using OceanWinForms.Util;
using OceanWinForms.CustomControls;
using OceanWinForms.Controller.Delegates;
using System.Diagnostics;

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
        private bool _wasValidationMessage;
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

            _groupBoxOcean.ButtonDeleteClicked += OnButtonDeleteClick;
            _groupBoxOcean.ButtonPauseClicked += OnButtonPauseClick;
            _groupBoxOcean.ButtonResumeClicked += OnButtonResumeClick;


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

        #region Properties
        public AutoResetEvent AutoResetEvent { get => _autoResetEvent; }
        #endregion

        #region Events
        private event OceanSimulationEventHandler _OceanSimulationFinished;
        private event OceanSimulationEventHandler _OceanHasBeenDeleted;
        private event OceanSimulationEventHandler _OceanHasBeenPaused;
        private event OceanSimulationEventHandler _OceanHasBeenResumed;

        public event OceanSimulationEventHandler OceanSimulationFinished
        {
            add
            {
                _OceanSimulationFinished += value;
            }
            remove
            {
                _OceanSimulationFinished -= value;
            }
        }
        public event OceanSimulationEventHandler OceanHasBeenDeleted
        {
            add
            {
                _OceanHasBeenDeleted += value;
            }
            remove
            {
                _OceanHasBeenDeleted -= value;
            }
        }
        public event OceanSimulationEventHandler OceanHasBeenPaused
        {
            add
            {
                _OceanHasBeenPaused += value;
            }
            remove
            {
                _OceanHasBeenPaused -= value;
            }
        }
        public event OceanSimulationEventHandler OceanHasBeenResumed
        {
            add
            {
                _OceanHasBeenResumed += value;
            }
            remove
            {
                _OceanHasBeenResumed -= value;
            }
        }
        #endregion

        #region Methods

        #region Private methods
        private void DisplayStats()
        {
            ChangeControls(
                () =>
                {
                    _groupBoxOcean.LblNumberOfIterations.Text = String.Format("Iteration number: {0}", _ocean.CurrentIteration);
                },
              _groupBoxOcean.LblNumberOfIterations);

            ChangeControls(
                () =>
                {
                    _groupBoxOcean.LblNumberOfObstacles.Text = String.Format("Obstacles: {0}", _ocean.NumObstacles);
                },
             _groupBoxOcean.LblNumberOfObstacles);

            ChangeControls(
                () =>
                {
                    _groupBoxOcean.LblNumberOfPredators.Text = String.Format("Predators: {0}", _ocean.NumPredators);
                },
              _groupBoxOcean.LblNumberOfPredators);

            ChangeControls(
                () =>
                {
                    _groupBoxOcean.LblNumberOfPrey.Text = String.Format("Prey: {0}", _ocean.NumPrey);
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

            for (int row = 0; row < _ocean.NumRows; row++)
            {
                for (int column = 0; column < _ocean.NumColumns; column++)
                {
                    PictureBox? pb = _groupBoxOcean.TableLayoutPaneltOcean.Controls["pb" + row + "" + column] as PictureBox;

                    if (pb == null)
                    {
                        continue;
                    }

                    if (_ocean[row, column] == null)
                    {
                        ChangeControls(
                        () =>
                          {
                              pb.Image = ArrayOfOceanViewers.BitmapEmpty;
                          },
                        _groupBoxOcean.TableLayoutPaneltOcean);

                    }
                    else
                    {
                        ChangeControls(
                        () =>
                          {
                              pb.Image = GetImage(_ocean[row, column]);
                          },
                        _groupBoxOcean.TableLayoutPaneltOcean);
                    }
                }
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

        private Bitmap GetImage(OceanLibrary.Ocean.CellTypes.Cell cell)
        {
            switch (cell?.CellType)
            {
                case OceanLibrary.Ocean.CellTypes.Enums.CellType.Obstacle:

                    return ArrayOfOceanViewers.BitmapObstacle;

                case OceanLibrary.Ocean.CellTypes.Enums.CellType.Predator:

                    return ArrayOfOceanViewers.BitmapPredator;

                case OceanLibrary.Ocean.CellTypes.Enums.CellType.Prey:

                    return ArrayOfOceanViewers.BitmapPrey;

                default:

                    return ArrayOfOceanViewers.BitmapEmpty;
            }
        }

        #region Checking for illegal thread calls
        private void ChangeControls(Action action, Control control)
        {
            try
            {
                if (!control.Disposing && !control.IsDisposed)
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
            catch
            {
                throw;
            }
        }
        #endregion

        #endregion

        #region Event handlers
        private void OnButtonDeleteClick(object sender, EventArgs e)
        {
            _groupBoxOcean.GroupBox.Hide();
            _OceanHasBeenDeleted.Invoke(this, e);
            _groupBoxOcean.Dispose();
        }

        private void OnButtonPauseClick(object sender, EventArgs e)
        {
            ChangeControls(
               () =>
               {
                   _groupBoxOcean.LblGameState.Text = "Paused";
               },
                _groupBoxOcean.LblGameState);

            _OceanHasBeenPaused.Invoke(this, e);
        }

        private void OnButtonResumeClick(object sender, EventArgs e)
        {
            ChangeControls(
               () =>
               {
                   _groupBoxOcean.LblGameState.Text = "Running...";
               },
                _groupBoxOcean.LblGameState);

            _OceanHasBeenResumed.Invoke(this, e);
        }
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

                    _OceanSimulationFinished.Invoke(this, EventArgs.Empty);

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
            try
            {
                DisplayStats();
                DisplayCells();
            }
            catch (InvalidCoordinateException e)
            {
                MessageBox.Show(String.Format("{0}: \nX: {1} \nY: {2}", e.Message, e.X, e.Y));
            }
            catch (ObjectDisposedException e)
            {
                Debug.WriteLine(e.Message);
            }

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
