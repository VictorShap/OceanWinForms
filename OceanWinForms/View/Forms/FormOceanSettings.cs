using OceanWinForms.UI;

namespace OceanWinForms
{
    public partial class FormOceanSettings : Form
    {
        #region Readonly
        private readonly ArrayOfOceanViewers _arrayOfOceanViewers;
        #endregion

        #region Ctor
        public FormOceanSettings()
        {
            InitializeComponent();
        }

        public FormOceanSettings(ArrayOfOceanViewers arrayOfOceansViewer) : this()
        {
            _arrayOfOceanViewers = arrayOfOceansViewer;
        }
        #endregion

        #region Methods

        #region Event handlers
        private void StartOcean_Click(object sender, EventArgs e)
        {
            _arrayOfOceanViewers.CreateGameField(txtTopCoordinate.Text, txtLeftCoordinate.Text, txtNumberOfIterations.Text, txtNumberOfObstacles.Text, txtNumberOfPredators.Text, txtNumberOfPrey.Text);

            this.Close();
        }
        #endregion

        #endregion
    }
}