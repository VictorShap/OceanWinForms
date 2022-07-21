using OceanWinForms.UI;

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

        #region Methods

        #region Event handlers
        private void SubmitNumberOfOceans_Click(object sender, EventArgs e)
        {
            new ArrayOfOceanViewers(txtNumberOfOceans.Text).Run();
        }
        #endregion

        #endregion
    }
}
