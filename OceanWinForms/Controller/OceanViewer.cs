using System.Text;
using OceanLibrary.UI.IOceanInterfaces;
using OceanLibrary.Ocean.UI.Enums;
using OceanLibrary.Ocean.OceanInterfaces;
using OceanLibrary.Ocean;
using OceanWinForms.UI.OceanViewerInterfaces;
using OceanLibrary.Exceptions;
using OceanWinForms.Util;

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
        private readonly int _threadDelay;
        private readonly int _iterations;
        private readonly int _obstacles;
        private readonly int _predators;
        private readonly int _prey;
        #endregion

        #region Fields
        private bool _isDone;
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

        public OceanViewer(FormGameField formGameField, AutoResetEvent autoResetEvent, int topPositionForOcean, int leftPositionForOcean, string iterations, string obstacles, string predators, string prey) : this(autoResetEvent, iterations, obstacles, predators, prey)
        {
            _gameField = formGameField;

            ChangeControls(
             () =>
             {
                 _gameField.groupBoxOcean.Location = new Point(leftPositionForOcean, topPositionForOcean);
             },
           _gameField.groupBoxOcean
                );

            System.Windows.Forms.Application.DoEvents();
        }
        #endregion

        #region Methods

        #region Private methods
        private void DisplayStats()
        {
            ChangeControls(
                () =>
                {
                    _gameField.labelNumberOfIterations.Text = "Iteration number: " + _ocean.CurrentIteration;
                },
              _gameField.labelNumberOfIterations);

            ChangeControls(
                () =>
                {
                    _gameField.labelNumberOfObstacles.Text = "Obstacles: " + _ocean.NumObstacles;
                },
             _gameField.labelNumberOfObstacles);

            ChangeControls(
                () =>
                {
                    _gameField.labelNumberOfPredators.Text = "Predators: " + _ocean.NumPredators;
                },
              _gameField.labelNumberOfPredators);

            ChangeControls(
                () =>
                {
                    _gameField.labelNumberOfPrey.Text = "Prey: " + _ocean.NumPrey;
                },
              _gameField.labelNumberOfPrey);

            ChangeControls(
                () =>
                {
                    _gameField.labelGameState.Text = "Running...";
                },
              _gameField.labelGameState);
        }

        private void DisplayCells()
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                for (int row = 0; row < _ocean.NumRows; row++)
                {
                    for (int column = 0; column < _ocean.NumColumns; column++)
                    {
                        if (_ocean[row, column] == null)
                        {
                            stringBuilder.Append(Ocean.DefaultCellImage);
                        }
                        else
                        {
                            stringBuilder.Append(_ocean[row, column].Image);
                        }
                    }

                    stringBuilder.AppendLine();
                }
            }
            catch (InvalidCoordinateException e)
            {
                MessageBox.Show(e.Message + ": \nX:" + e.X + "\n Y:" + e.Y);
            }

            ChangeControls(
              () =>
              {
                  _gameField.textBoxOcean.Suspend();
              },
             _gameField.textBoxOcean);

            ChangeControls(
             () =>
             {
                 _gameField.textBoxOcean.Text = stringBuilder.ToString();
             },
             _gameField.textBoxOcean);

            ChangeControls(
              () =>
              {
                  _gameField.textBoxOcean.Resume();
              },
             _gameField.textBoxOcean);
        }

        #region Checking for illegal thread calls
        private void ChangeControls(Action action, Control control)
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
                            _gameField.labelGameState.Text = "Starting...";
                        },
                        _gameField.labelGameState);

                    System.Windows.Forms.Application.DoEvents();

                    _autoResetEvent.Set();
                    _autoResetEvent.WaitOne();

                    break;

                case GameState.End:

                    ChangeControls(
                        () =>
                        {
                            _gameField.labelGameState.Text = "Simulation has been ended";
                        },
                        _gameField.labelGameState);

                    System.Windows.Forms.Application.DoEvents();

                    _isDone = true;

                    _autoResetEvent.Set();
                    _autoResetEvent.Dispose();

                    break;
            }
        }

        public void DisplayValidationMessage(bool wasFormatException)
        {
            if (wasFormatException)
            {
                MessageBox.Show("Invalid input, so the it will be set its default value");
            }
            else
            {
                MessageBox.Show("Invalid value, so it will be set to maximum possible value");
            }
        }

        public void DisplayIteration()
        {
            DisplayStats();
            DisplayCells();

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
