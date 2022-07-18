
namespace OceanWinForms.Controller
{
    internal class GroupBoxOcean
    {
        #region Consts
        private const int GroupBoxWidth = 527;
        private const int GroupBoxHeight = 523;
        private const int TableLayoutPanelWidth = 504;
        private const int TableLayoutPanelHeight = 293;
        private const int LblIterationsX = 20;
        private const int LblIterationsY = 34;
        private const int LblObstaclesX = 20;
        private const int LblObstaclesY = 59;
        private const int LblPredatorsX = 20;
        private const int LblPredatorsY = 87;
        private const int LblPreyX = 20;
        private const int LblPreyY = 117;
        private const int LblGameStateX = 20;
        private const int LblGameStateY = 487;
        private const int TablePanelOceanX = 6;
        private const int TablePanelOceanY = 150;
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
        public TableLayoutPanel TableLayoutPaneltOcean { get; private set; }
        #endregion

        #region Methods

        #region Creating controls
        private GroupBox CreateGroupBox(int number, int rows, int columns)
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

            TableLayoutPaneltOcean = CreateTableLayoutPanel(number, rows, columns);
            AddControl(groupBox, TableLayoutPaneltOcean, new Point(TablePanelOceanX, TablePanelOceanY));

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

        private TableLayoutPanel CreateTableLayoutPanel(int number, int rows, int columns)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
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
                    tableLayoutPanel.Controls.Add(new Label() { Size = new Size(30, 30), Name = "lbl" + i + "" + j }, i, j);
                }
            }

            AddStylesForTable(tableLayoutPanel, columns, rows);

            return tableLayoutPanel;
        }

        private void AddControl(Control whereToAdd, Control control, Point point)
        {
            control.Location = point;
            whereToAdd.Controls.Add(control);
        }

        private void AddStylesForTable(TableLayoutPanel tableLayoutPanel, int columns, int rows)
        {
            TableLayoutColumnStyleCollection columnStyles = tableLayoutPanel.ColumnStyles;

            foreach (ColumnStyle style in columnStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Width = TableLayoutPanelWidth / columns;
            }

            TableLayoutRowStyleCollection rowStyles = tableLayoutPanel.RowStyles;

            foreach (RowStyle style in rowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = TableLayoutPanelHeight / rows;
            }
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
