﻿using OceanWinForms.UI.OceanViewerInterfaces;

namespace OceanWinForms.UI
{
    public class ArrayOfOceanViewers
    {
        #region Readonly
        private readonly List<IOceanLaunch> _oceanViewers;
        private readonly FormGameField _gameField;
        #endregion

        #region Static
        public readonly static Bitmap BitmapEmpty;
        public readonly static Bitmap BitmapObstacle;
        public readonly static Bitmap BitmapPredator;
        public readonly static Bitmap BitmapPrey;
        public readonly static Bitmap BitmapKillerWhale;
        #endregion

        #region Fields
        private int _numActiveOceans;
        #endregion

        #region Ctors
        static ArrayOfOceanViewers()
        {
            BitmapEmpty = new Bitmap(@"..\..\..\Resources\Images\empty.jpg");
            BitmapObstacle = new Bitmap(@"..\..\..\Resources\Images\obstacle.png");
            BitmapPredator = new Bitmap(@"..\..\..\Resources\Images\predator.jpg");
            BitmapPrey = new Bitmap(@"..\..\..\Resources\Images\prey.jpg");
            BitmapKillerWhale = new Bitmap(@"..\..\..\Resources\Images\images.jpg");
        }

        private ArrayOfOceanViewers()
        {
            _gameField = new FormGameField();
        }

        public ArrayOfOceanViewers(int length) : this()
        {
            _oceanViewers = new List<IOceanLaunch>(length);
        }

        public ArrayOfOceanViewers(string length) : this()
        {
            _oceanViewers = new List<IOceanLaunch>(Validate(length));
        }

        public ArrayOfOceanViewers(List<IOceanLaunch> oceanViewers) : this()
        {
            _oceanViewers = oceanViewers;
        }
        #endregion

        #region Methods

        #region Private Methods
        private void Iterate()
        {
            while (_oceanViewers.Count > 0)
            {
                LaunchActiveOceans();
            }
        }

        private void LaunchActiveOceans()
        {
            foreach (IOceanLaunch oceanLauncher in _oceanViewers.ToArray())
            {
                oceanLauncher?.AutoResetEvent?.Set();
                oceanLauncher?.AutoResetEvent?.WaitOne();
            }
        }

        private void InitializeViewers(string top, string left, string iterations, string obstacles, string predators, string prey)
        {
            int topInt;
            int leftInt;
            bool wholeSuccess;

            wholeSuccess = IsValid(top, left, out topInt, out leftInt);

            IOceanLaunch currentOceanViewer = new OceanViewer(_gameField, new AutoResetEvent(false), ++_numActiveOceans, topInt, leftInt, iterations, obstacles, predators, prey);
            currentOceanViewer.OceanSimulationFinished += OnOceanSimulationFinish;
            currentOceanViewer.OceanHasBeenDeleted += OnOceanHasBeenDeleted;
            currentOceanViewer.OceanHasBeenPaused += OnOceanHasBeenPaused;
            currentOceanViewer.OceanHasBeenResumed += OnOceanHasBeenResumed;
            _oceanViewers.Add(currentOceanViewer);

            if (!wholeSuccess)
            {
                currentOceanViewer.DisplayValidationMessage(!wholeSuccess);
            }

            Task task = currentOceanViewer.Launch();
            task.Start();

            currentOceanViewer.AutoResetEvent.WaitOne();

            if (_numActiveOceans == _oceanViewers.Capacity)
            {
                Task.Run(() => Iterate());

                _numActiveOceans = 0;
            }
        }

        private bool IsValid(string top, string left, out int topInt, out int leftInt)
        {
            bool successTop = Int32.TryParse(top, out topInt);
            bool successLeft = Int32.TryParse(left, out leftInt);

            return successTop && successLeft;
        }

        private int Validate(string str)
        {
            int number;

            if (!Int32.TryParse(str, out number))
            {
                MessageBox.Show("Invalid input, so the it will be set its default value");
                number = 1;
            }

            return number;
        }
        #endregion

        #region Event handlers
        private void OnOceanSimulationFinish(object sender, EventArgs e)
        {
            _oceanViewers.Remove(sender as IOceanLaunch);
        }

        private void OnOceanHasBeenDeleted(object sender, EventArgs e)
        {
            _oceanViewers.Remove(sender as IOceanLaunch);

            _numActiveOceans--;

            if (_oceanViewers.Count == 0 && _numActiveOceans < 0)
            {
                MessageBox.Show("There are no oceans on the game field, so the form will be closed");

                _gameField.Close();
            }
        }

        private bool OnOceanHasBeenPaused(object sender, EventArgs e)
        {
            if (_oceanViewers.Remove(sender as IOceanLaunch))
            {
                _numActiveOceans++;

                return true;
            }

            return false;
        }

        private bool OnOceanHasBeenResumed(object sender, EventArgs e)
        {
            if (!_oceanViewers.Contains(sender as IOceanLaunch) && _numActiveOceans > 0)
            {
                _oceanViewers.Add(sender as IOceanLaunch);

                if (_oceanViewers.Count == 1)
                {
                    Task.Run(() => Iterate());
                }

                _numActiveOceans--;

                return true;
            }

            return false;
        }
        #endregion

        #region Public methods
        public void Run()
        {
            for (int i = 0; i < _oceanViewers.Capacity; i++)
            {
                new FormOceanSettings(this).Show();
            }
        }

        public void CreateGameField(string topCoordinate, string leftCoordinate, string iterations, string obstacles, string predators, string prey)
        {
            _gameField.Show();

            Task.Run(() => this.InitializeViewers(topCoordinate, leftCoordinate, iterations, obstacles, predators, prey));
        }
        #endregion

        #endregion
    }
}
