using OceanWinForms.UI;

namespace OceanWinForms
{
    public partial class FormOceanSettings : Form
    {
        private readonly ArrayOfOceanViewers _arrayOfOceanViewers;

        public FormOceanSettings()
        {
            InitializeComponent();
        }

        public FormOceanSettings(ArrayOfOceanViewers arrayOfOceansViewer) : this()
        {
            _arrayOfOceanViewers = arrayOfOceansViewer;
        }

        private void StartOcean_Click(object sender, EventArgs e)
        {
            _arrayOfOceanViewers.CreateGameField(textBoxTopCoordinate.Text, textBoxLeftCoordinate.Text, textBoxNumberOfIterations.Text, textBoxNumberOfObstacles.Text, textBoxNumberOfPredators.Text, textBoxNumberOfPrey.Text);

            this.Close();
        }
    }
}