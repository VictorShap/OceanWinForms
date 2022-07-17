using OceanWinForms.UI.OceanViewerInterfaces;

namespace OceanWinForms.UI
{
    public class ArrayOfOceanViewers
    {
        #region Readonly
        private readonly IOceanLaunch[] _oceanLaunchers;
        #endregion

        #region Static
        public static FormGameField GameField;
        #endregion

        #region Fields
        private bool _isDone;
        private int count;
        #endregion

        #region Ctors
        public ArrayOfOceanViewers()
        {
            int number;

            Console.WriteLine("How many oceans do you want?");
            int.TryParse(Console.ReadLine(), out number);

            _oceanLaunchers = new IOceanLaunch[number];
        }

        public ArrayOfOceanViewers(int length)
        {
            _oceanLaunchers = new IOceanLaunch[length];
        }

        public ArrayOfOceanViewers(IOceanLaunch[] oceanLaunchers)
        {
            _oceanLaunchers = oceanLaunchers;
        }
        #endregion

        #region Methods

        #region Private Methods
        private void Iterate()
        {
            while (!_isDone)
            {
                LaunchActiveOceans(_oceanLaunchers);
            }
        }

        private void LaunchActiveOceans(IOceanLaunch[] oceanLaunches)
        {
            int i = 0;

            foreach (IOceanLaunch oceanLauncher in oceanLaunches)
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
        #endregion 

        #region Public methods
        public void Run()
        {
            for (int i = 0; i < _oceanLaunchers.Length; i++)
            {
                new FormOceanSettings(this);
            }
        }

        public void InitializeViewers(string top, string left, string iterations, string obstacles, string predators, string prey)
        {
            int topInt;
            int leftInt;

            count++;

            Int32.TryParse(Console.ReadLine(), out topInt);
            Int32.TryParse(Console.ReadLine(), out leftInt);

            _oceanLaunchers[count - 1] = new OceanViewer(GameField, new AutoResetEvent(false), topInt, leftInt, iterations, obstacles, predators, prey);

            Task task = _oceanLaunchers[count - 1].Launch();
            task.Start();

            _oceanLaunchers[count - 1].AutoResetEvent.WaitOne();

            if (count == _oceanLaunchers.Length)
            {
                Iterate();
            }
        }
        #endregion

        #endregion
    }
}
