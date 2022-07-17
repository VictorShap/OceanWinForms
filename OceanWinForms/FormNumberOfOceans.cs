using OceanWinForms.UI;

namespace OceanWinForms
{
    public partial class FormNumberOfOceans : Form
    {
        public FormNumberOfOceans()
        {
            InitializeComponent();
        }

        private void buttonSubmitNumberOfOceans_Click(object sender, EventArgs e)
        {
            int numberOfOceans;

            Int32.TryParse(textBoxNumberOfOceans.Text, out numberOfOceans);

            ArrayOfOceanViewers arrayOfOceansViewer = new ArrayOfOceanViewers(numberOfOceans);

            new FormOceanSettings(arrayOfOceansViewer).Show();
        }
    }
}
