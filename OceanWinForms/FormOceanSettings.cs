using OceanWinForms.UI;

namespace OceanWinForms
{
    public partial class FormOceanSettings : Form
    {
        private readonly ArrayOfOceanViewers _arrayOfOceansViewer;

        private Label labelNumberOfIterations;
        private TextBox textBoxNumberOfIterations;
        private TextBox textBoxNumberOfObstacles;
        private Label labelNumberOfObstacles;
        private TextBox textBoxNumberOfPredators;
        private Label labelNumberOfPredators;
        private TextBox textBoxNumberOfPrey;
        private Label labelNumberOfPrey;
        private Button buttonStart;

        public FormOceanSettings()
        {
            InitializeComponent();
        }

        public FormOceanSettings(ArrayOfOceanViewers arrayOfOceansViewer) : this()
        {
            _arrayOfOceansViewer = arrayOfOceansViewer;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Task.Run(() => _arrayOfOceansViewer.InitializeViewers(textBoxTopCoordinate.Text, textBoxLeftCoordinate.Text, textBoxNumberOfIterations.Text, textBoxNumberOfObstacles.Text, textBoxNumberOfPredators.Text, textBoxNumberOfPrey.Text));
        }
    }
}