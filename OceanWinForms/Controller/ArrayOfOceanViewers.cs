using OceanWinForms.UI.OceanViewerInterfaces;

namespace OceanWinForms.UI
{
    public class ArrayOfOceanViewers
    {
        #region Readonly
        private readonly IOceanLaunch[] _oceanViewers;
        private readonly FormGameField _gameField;
        #endregion

        #region Static
        public static Bitmap BitmapEmpty;
        public static Bitmap BitmapObstacle;
        public static Bitmap BitmapPredator;
        public static Bitmap BitmapPrey;
        #endregion

        #region Fields
        private bool _isDone;
        private int count;
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
            _oceanViewers = new IOceanLaunch[length];
        }

        public ArrayOfOceanViewers(string length) : this()
        {
            int number;
            Int32.TryParse(length, out number);

            _oceanViewers = new IOceanLaunch[number];
        }

        public ArrayOfOceanViewers(IOceanLaunch[] oceanLaunchers) : this()
        {
            _oceanViewers = oceanLaunchers;
        }
        #endregion

        #region Methods

        #region Private Methods
        private void Iterate()
        {
            while (!_isDone)
            {
                LaunchActiveOceans(_oceanViewers);
            }
        }

        private void LaunchActiveOceans(IOceanLaunch[] oceanLaunchers)
        {
            int i = 0;

            foreach (IOceanLaunch oceanLauncher in oceanLaunchers)
            {
                if (!oceanLauncher.IsDone)
                {
                    i++;

                    oceanLauncher.AutoResetEvent.Set();
                    oceanLauncher.AutoResetEvent.WaitOne();
                }
            }

            if (i == 0)
            {
                _isDone = true;
            }
        }

        private void InitializeViewers(string top, string left, string iterations, string obstacles, string predators, string prey)
        {
            int topInt;
            int leftInt;

            count++;

            Int32.TryParse(top, out topInt);
            Int32.TryParse(left, out leftInt);

            _oceanViewers[count - 1] = new OceanViewer(_gameField, new AutoResetEvent(false), count, topInt, leftInt, iterations, obstacles, predators, prey);

            Task task = _oceanViewers[count - 1].Launch();
            task.Start();

            _oceanViewers[count - 1].AutoResetEvent.WaitOne();

            if (count == _oceanViewers.Length)
            {
                Iterate();
            }
        }
        #endregion 

        #region Public methods
        public void Run()
        {
            for (int i = 0; i < _oceanViewers.Length; i++)
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
