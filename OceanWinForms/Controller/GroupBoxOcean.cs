
namespace OceanWinForms.Controller
{
    internal class GroupBoxOcean
    {
        #region Consts
        private const int GroupBoxWidth = 527;
        private const int GroupBoxHeight = 503;
        private const int TxtOceanWidth = 504;
        private const int TxtOceanHeight = 293;
        private const int LblIterationsX = 20;
        private const int LblIterationsY = 34;
        private const int LblObstaclesX = 20;
        private const int LblObstaclesY = 59;
        private const int LblPredatorsX = 20;
        private const int LblPredatorsY = 87;
        private const int LblPreyX = 20;
        private const int LblPreyY = 117;
        private const int LblGameStateX = 20;
        private const int LblGameStateY = 467;
        private const int TxtOceanX = 6;
        private const int TxtOceanY = 150;
        #endregion

        #region Ctors
        public GroupBoxOcean(int number)
        {
            GroupBox = CreateGroupBox(number);
        }
        #endregion

        #region Properties
        public GroupBox GroupBox { get; private set; }
        public Label LblNumberOfIterations { get; private set; }
        public Label LblNumberOfObstacles { get; private set; }
        public Label LblNumberOfPredators { get; private set; }
        public Label LblNumberOfPrey { get; private set; }
        public Label LblGameState { get; private set; }
        public TextBox TxtOcean { get; private set; }
        #endregion

        #region Methods

        #region Creating controls
        private GroupBox CreateGroupBox(int number)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Size = new Size(GroupBoxWidth, GroupBoxHeight);
            groupBox.Text = "Ocean " + number;
            groupBox.Name = "grbxOcean" + number;

            LblNumberOfIterations = CreateLabel("Iteration number: ", "lblNumberOfIterations", number);
            AddControl(groupBox, LblNumberOfIterations, new Point(LblIterationsX, LblIterationsY));

            LblNumberOfObstacles = CreateLabel("Obstacles: ", "lblNumberOfObstacles", number);
            AddControl(groupBox, LblNumberOfObstacles, new Point(LblObstaclesX, LblObstaclesY));

            LblNumberOfPredators = CreateLabel("Predators: ", "lblNumberOfPredators", number);
            AddControl(groupBox, LblNumberOfPredators, new Point(LblPredatorsX, LblPredatorsY));

            LblNumberOfPrey = CreateLabel("Prey: ", "lblNumberOfPrey", number);
            AddControl(groupBox, LblNumberOfPrey, new Point(LblPreyX, LblPreyY));

            LblGameState = CreateLabel("", "labelGameState", number);
            AddControl(groupBox, LblGameState, new Point(LblGameStateX, LblGameStateY));

            TxtOcean = CreateTextBox(number);
            AddControl(groupBox, TxtOcean, new Point(TxtOceanX, TxtOceanY));

            return groupBox;
        }

        private Label CreateLabel(string text, string name, int number)
        {
            Label label = new Label();
            label.Text = text + number;
            label.Name = name + number;
            label.Size = new Size(200, 28);

            return label;
        }

        private TextBox CreateTextBox(int number)
        {
            TextBox textBox = new TextBox();
            textBox.Name = "txtOcean" + number;
            textBox.Enabled = false;
            textBox.Multiline = true;
            textBox.Size = new Size(TxtOceanWidth, TxtOceanHeight);
            textBox.Font = new Font(FontFamily.GenericMonospace, textBox.Font.Size);

            return textBox;
        }

        private void AddControl(Control whereToAdd, Control control, Point point)
        {
            control.Location = point;
            whereToAdd.Controls.Add(control);
        }
        #endregion

        #endregion
    }
}
