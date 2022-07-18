using OceanWinForms.UI;
using OceanWinForms.View;

namespace OceanWinForms
{
    public partial class FormNumberOfOceans : Form
    {
        #region Ctor
        public FormNumberOfOceans()
        {
            InitializeComponent();
        }
        #endregion

        #region Event handlers
        private void SubmitNumberOfOceans_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            new ArrayOfOceanViewers(txtNumberOfOceans.Text).Run();
        }
        #endregion
    }
}
