namespace OceanWinForms.CustomControls
{
    internal class GroupBoxOcean : Control
    {
        #region Consts
        private const int GroupBoxWidth = 900;
        private const int GroupBoxHeight = 740;
        private const int LabelWidth = 875;
        private const int LabelHeight = 40;
        private const int PBWidth = 30;
        private const int PBHeight = 30;
        private const int TableLayoutPanelWidth = 860;
        private const int TableLayoutPanelHeight = 333;
        private const int LblIterationsX = 20;
        private const int LblIterationsY = 34;
        private const int LblObstaclesX = 20;
        private const int LblObstaclesY = 82;
        private const int LblPredatorsX = 20;
        private const int LblPredatorsY = 130;
        private const int LblPreyX = 20;
        private const int LblPreyY = 178;
        private const int LblGameStateX = 20;
        private const int LblGameStateY = 680;
        private const int TablePanelOceanX = 20;
        private const int TablePanelOceanY = 240;
        private float DefaultFontSIze = 13.8f;
        #endregion

        #region Ctors
        public GroupBoxOcean(int number, int rows, int columns)
        {
            GroupBox = CreateGroupBox(number, rows, columns);
        }
        #endregion

        #region Properties
        public GroupBox GroupBox { get; private set; }
        public Label LblNumberOfIterations { get; private set; }
        public Label LblNumberOfObstacles { get; private set; }
        public Label LblNumberOfPredators { get; private set; }
        public Label LblNumberOfPrey { get; private set; }
        public Label LblGameState { get; private set; }
        public TableLayoutPanelDoubleBuff TableLayoutPaneltOcean { get; private set; }
        #endregion

        #region Methods

        #region Creating controls
        private GroupBox CreateGroupBox(int number, int rows, int columns)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Size = new Size(GroupBoxWidth, GroupBoxHeight);
            groupBox.Text = "Ocean " + number;
            groupBox.Name = "grbxOcean" + number;
            groupBox.BackColor = Color.DarkOliveGreen;
            groupBox.ForeColor = Color.White;
            groupBox.Font = new Font("Sitka Text", 13.8f);

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

            TableLayoutPaneltOcean = CreateTableLayoutPanel(number, rows, columns);
            AddControl(groupBox, TableLayoutPaneltOcean, new Point(TablePanelOceanX, TablePanelOceanY));

            return groupBox;
        }

        private Label CreateLabel(string text, string name, int number)
        {
            Label label = new Label();
            label.Text = text + number;
            label.Name = name + number;
            label.AutoSize = false;
            label.Size = new Size(LabelWidth, LabelHeight);
            label.Font = new Font("Sitka Text", DefaultFontSIze);
            label.ForeColor = Color.White;
            label.BackColor = Color.CornflowerBlue;

            return label;
        }

        private TableLayoutPanelDoubleBuff CreateTableLayoutPanel(int number, int rows, int columns)
        {
            TableLayoutPanelDoubleBuff tableLayoutPanel = new TableLayoutPanelDoubleBuff();
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.Name = "tableLayoutPanel" + number;
            tableLayoutPanel.ColumnCount = columns;
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.Size = new Size(TableLayoutPanelWidth, TableLayoutPanelHeight);
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.Visible = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tableLayoutPanel.Controls.Add(new PictureBox() { Size = new Size(PBWidth, PBHeight), Name = "pb" + i + "" + j, SizeMode = PictureBoxSizeMode.Zoom }, j, i);
                }
            }

            return tableLayoutPanel;
        }

        private void AddControl(Control whereToAdd, Control control, Point point)
        {
            control.Location = point;
            whereToAdd.Controls.Add(control);
        }
        #endregion

        #region Public
        public void DisposeElementsOnTable()
        {
            for (int i = 0; i < TableLayoutPaneltOcean.Controls.Count; i++)
            {
                TableLayoutPaneltOcean.Controls[i].Dispose();
            }

            TableLayoutPaneltOcean.Controls.Clear();
        }
        #endregion

        #endregion
    }
}
