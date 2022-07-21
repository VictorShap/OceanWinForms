using OceanWinForms.UI.OceanViewerInterfaces;

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
        #endregion

        #region Fields
        private int _count;
        #endregion

        #region Ctors
        static ArrayOfOceanViewers()
        {

            BitmapEmpty = new Bitmap(@"E:\SoftServe\Projects\OceanWinForms\OceanWinForms\Resources\Images\empty.jpg");
            BitmapObstacle = new Bitmap(@"E:\SoftServe\Projects\OceanWinForms\OceanWinForms\Resources\Images\obstacle.png");
            BitmapPredator = new Bitmap(@"E:\SoftServe\Projects\OceanWinForms\OceanWinForms\Resources\Images\predator.jpg");
            BitmapPrey = new Bitmap(@"E:\SoftServe\Projects\OceanWinForms\OceanWinForms\Resources\Images\prey.jpg");
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
            int number;

            if (!Int32.TryParse(length, out number))
            {
                MessageBox.Show("Invalid input, so the it will be set its default value");
                number = 1;
            }

            _oceanViewers = new List<IOceanLaunch>(number);
        }

        public ArrayOfOceanViewers(List<IOceanLaunch> oceanLaunchers) : this()
        {
            _oceanViewers = oceanLaunchers;
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
                oceanLauncher?.AutoResetEvent.Set();
                oceanLauncher?.AutoResetEvent.WaitOne();
            }
        }

        private void InitializeViewers(string top, string left, string iterations, string obstacles, string predators, string prey)
        {
            int topInt;
            int leftInt;
            bool wholeSuccess;

            bool successTop = Int32.TryParse(top, out topInt);
            bool successLeft = Int32.TryParse(left, out leftInt);

            wholeSuccess = successTop && successLeft;

            IOceanLaunch currentOceanViewer = new OceanViewer(_gameField, new AutoResetEvent(false), ++_count, topInt, leftInt, iterations, obstacles, predators, prey);
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

            if (_count == _oceanViewers.Capacity)
            {
                Task.Run(() => Iterate());
            }
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

            if (_oceanViewers.Count == 0)
            {
                MessageBox.Show("There are no oceans on the game field, so the form will be closed");

                _gameField.Close();
            }
        }

        private void OnOceanHasBeenPaused(object sender, EventArgs e)
        {
            _oceanViewers.Remove(sender as IOceanLaunch);
        }

        private void OnOceanHasBeenResumed(object sender, EventArgs e)
        {
            _oceanViewers.Add(sender as IOceanLaunch);

            if (_oceanViewers.Count == 1)
            {
                Task.Run(() => Iterate());
            }
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
            this._gameField.Show();

            Task.Run(() => this.InitializeViewers(topCoordinate, leftCoordinate, iterations, obstacles, predators, prey));
        }
        #endregion

        #endregion
    }
}
