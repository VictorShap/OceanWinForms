using System.Text;
using OceanLibrary.UI.IOceanInterfaces;
using OceanLibrary.Ocean.UI.Enums;
using OceanLibrary.Ocean.OceanInterfaces;
using OceanLibrary.Ocean;
using OceanWinForms.UI.OceanViewerInterfaces;

namespace OceanWinForms.UI
{
    public class OceanViewer : IOceanViewer, IOceanLaunch
    {
        #region Consts
        private const int IterationCursorDefaultLeftPosition = 18;
        private const int ObstaclesCursorDefaultLeftPosition = 11;
        private const int PredatorsCursorDefaultLeftPosition = 11;
        private const int PreyCursorDefaultLeftPosition = 6;
        private const int IterationCursorDefaultTopPosition = 6;
        private const int ObstaclesCursorDefaultTopPosition = 5;
        private const int PredatorsCursorDefaultTopPosition = 4;
        private const int PreyCursorDefaultTopPosition = 3;
        private const int CursorDefaultLeftPosition = 0;
        private const int CursorDefaultTopPosition = 6;
        private const int DefaultThreadDelay = 1500;
        #endregion

        #region Readonly
        private readonly IOceanView _ocean; // field for interacting with the ocean
        private readonly AutoResetEvent _autoResetEvent;
        private FormGameField _gameField;
        private readonly int _topPositionForOcean;
        private readonly int _leftPositionForOcean;
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
        public OceanViewer()
        {
            _leftPositionForOcean = CursorDefaultLeftPosition;
            _topPositionForOcean = CursorDefaultTopPosition;
            _threadDelay = DefaultThreadDelay;
            //_gameField = new FormGameField();

            _ocean = new Ocean(this);
        }

        public OceanViewer(int topPositionForOcean, int leftPositionForOcean) : this()
        {
            _topPositionForOcean = topPositionForOcean;
            _leftPositionForOcean = leftPositionForOcean;
        }

        public OceanViewer(string iterations, string obstacles, string predators, string prey) : this()
        {
            Int32.TryParse(iterations, out _iterations);
            Int32.TryParse(obstacles, out _obstacles);
            Int32.TryParse(predators, out _predators);
            Int32.TryParse(prey, out _prey);
        }

        public OceanViewer(int topPositionForOcean, int leftPositionForOcean, string iterations, string obstacles, string predators, string prey) : this(iterations, obstacles, predators, prey)
        {
            _topPositionForOcean = topPositionForOcean;
            _leftPositionForOcean = leftPositionForOcean;
        }

        public OceanViewer(IOceanView ocean) : this()
        {
            _ocean = ocean;
        }

        public OceanViewer(IOceanView ocean, string iterations, string obstacles, string predators, string prey) : this(iterations, obstacles, predators, prey)
        {
            _ocean = ocean;
        }

        public OceanViewer(IOceanView ocean, int topPositionForOcean, int leftPositionForOcean) : this(ocean)
        {
            _topPositionForOcean = topPositionForOcean;
            _leftPositionForOcean = leftPositionForOcean;
        }

        public OceanViewer(IOceanView ocean, int topPositionForOcean, int leftPositionForOcean, string iterations, string obstacles, string predators, string prey) : this(ocean, topPositionForOcean, leftPositionForOcean)
        {
            Int32.TryParse(iterations, out _iterations);
            Int32.TryParse(obstacles, out _obstacles);
            Int32.TryParse(predators, out _predators);
            Int32.TryParse(prey, out _prey);
        }

        public OceanViewer(AutoResetEvent autoResetEvent) : this()
        {
            _autoResetEvent = autoResetEvent;
        }

        public OceanViewer(AutoResetEvent autoResetEvent, string iterations, string obstacles, string predators, string prey) : this(autoResetEvent)
        {
            Int32.TryParse(iterations, out _iterations);
            Int32.TryParse(obstacles, out _obstacles);
            Int32.TryParse(predators, out _predators);
            Int32.TryParse(prey, out _prey);
        }

        public OceanViewer(AutoResetEvent autoResetEvent, int topPositionForOcean, int leftPositionForOcean) : this(autoResetEvent)
        {
            _topPositionForOcean = topPositionForOcean;
            _leftPositionForOcean = leftPositionForOcean;
        }

        public OceanViewer(AutoResetEvent autoResetEvent, int topPositionForOcean, int leftPositionForOcean, string iterations, string obstacles, string predators, string prey) : this(autoResetEvent, topPositionForOcean, leftPositionForOcean)
        {
            Int32.TryParse(iterations, out _iterations);
            Int32.TryParse(obstacles, out _obstacles);
            Int32.TryParse(predators, out _predators);
            Int32.TryParse(prey, out _prey);
        }

        public OceanViewer(FormGameField formGameField, AutoResetEvent autoResetEvent, int topPositionForOcean, int leftPositionForOcean, string iterations, string obstacles, string predators, string prey) : this(autoResetEvent, topPositionForOcean, leftPositionForOcean)
        {
            _gameField = formGameField;
            //  _gameField.Show();
            System.Windows.Forms.Application.DoEvents();


            Int32.TryParse(iterations, out _iterations);
            Int32.TryParse(obstacles, out _obstacles);
            Int32.TryParse(predators, out _predators);
            Int32.TryParse(prey, out _prey);
        }

        public OceanViewer(AutoResetEvent autoResetEvent, IOceanView ocean) : this(autoResetEvent)
        {
            _ocean = ocean;
        }

        public OceanViewer(AutoResetEvent autoResetEvent, IOceanView ocean, string iterations, string obstacles, string predators, string prey) : this(autoResetEvent, ocean)
        {
            Int32.TryParse(iterations, out _iterations);
            Int32.TryParse(obstacles, out _obstacles);
            Int32.TryParse(predators, out _predators);
            Int32.TryParse(prey, out _prey);
        }

        public OceanViewer(AutoResetEvent autoResetEvent, IOceanView ocean, int topPositionForOcean, int leftPositionForOcean) : this(autoResetEvent, ocean)
        {
            _topPositionForOcean = topPositionForOcean;
            _leftPositionForOcean = leftPositionForOcean;
        }

        public OceanViewer(AutoResetEvent autoResetEvent, IOceanView ocean, int topPositionForOcean, int leftPositionForOcean, string iterations, string obstacles, string predators, string prey) : this(autoResetEvent, ocean, topPositionForOcean, leftPositionForOcean)
        {
            Int32.TryParse(iterations, out _iterations);
            Int32.TryParse(obstacles, out _obstacles);
            Int32.TryParse(predators, out _predators);
            Int32.TryParse(prey, out _prey);
        }

        #endregion

        #region Methods

        #region Private methods
        private void DisplayStats()
        {
            _gameField.labelNumberOfIterations.Text = "Iteration number: " + _ocean.CurrentIteration;
            _gameField.labelNumberOfObstacles.Text = "Obstacles: " + _ocean.NumObstacles;
            _gameField.labelNumberOfPredators.Text = "Predators: " + _ocean.NumPredators;
            _gameField.labelNumberOfPrey.Text = "Prey: " + _ocean.NumPrey;

            _gameField.labelGameState.Text = "Running...";
        }

        private void DisplayCells()
        {
            StringBuilder stringBuilder = new StringBuilder();

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

            _gameField.textBoxOcean.Suspend();
            _gameField.textBoxOcean.Text = stringBuilder.ToString();
            _gameField.textBoxOcean.Resume();
        }

        #region Checking for illegal thread calls
        private void ChangeLabelGameState(Action action, Control control)
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

                    _gameField.labelGameState.Text = "Starting...";
                    System.Windows.Forms.Application.DoEvents();

                    _autoResetEvent.Set();
                    _autoResetEvent.WaitOne();

                    break;

                case GameState.End:

                    _gameField.labelGameState.Text = "Simulation has been ended";
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
