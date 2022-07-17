using OceanWinForms.UI;

namespace OceanWinForms
{
    public partial class FormNumberOfOceans : Form
    {
        public FormNumberOfOceans()
        {
            InitializeComponent();
        }

        private void SubmitNumberOfOceans_Click(object sender, EventArgs e)
        {
            new ArrayOfOceanViewers(textBoxNumberOfOceans.Text).Run();
        }
    }
}
