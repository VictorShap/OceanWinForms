using System.Reflection;
using OceanWinForms.Controller.Delegates;
using OceanWinForms.Util;

namespace OceanWinForms.CustomControls
{
    internal class GroupBoxOcean : IDisposable
    {
        #region Consts
        private const int GroupBoxWidth = 900;
        private const int GroupBoxHeight = 800;
        private const int LabelWidth = 875;
        private const int LabelHeight = 40;
        private const int PBWidth = 30;
        private const int PBHeight = 30;
        private const int TableLayoutPanelWidth = 860;
        private const int TableLayoutPanelHeight = 333;
        private const int ButtonWidth = 125;
        private const int ButtonHeight = 38;
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
        private const int ButtonDeleteX = 710;
        private const int ButtonDeleteY = 740;
        private const int ButtonPauseX = 390;
        private const int ButtonPauseY = 740;
        private const int ButtonResumeX = 60;
        private const int ButtonResumeY = 740;
        private float FontSizeForLabels = 13.8f;
        private float FontSizeForButtons = 12f;
        #endregion

        #region Ctors
        public GroupBoxOcean(int indexNumber, int rows, int columns)
        {
            GroupBox = CreateGroupBox(indexNumber, rows, columns);
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
        public Button ButtonDelete { get; private set; }
        public Button ButtonPause { get; private set; }
        public Button ButtonResume { get; private set; }
        #endregion

        #region Events
        private event OceanSimulationEventHandler _ButtonDeleteClicked;
        private event OceanSimulationEventHandler _ButtonResumeClicked;
        private event OceanSimulationEventHandler _ButtonPauseClicked;

        public event OceanSimulationEventHandler ButtonDeleteClicked
        {
            add
            {
                _ButtonDeleteClicked += value;
            }
            remove
            {
                _ButtonDeleteClicked -= value;
            }
        }
        public event OceanSimulationEventHandler ButtonResumeClicked
        {
            add
            {
                _ButtonResumeClicked += value;
            }
            remove
            {
                _ButtonResumeClicked -= value;
            }
        }
        public event OceanSimulationEventHandler ButtonPauseClicked
        {
            add
            {
                _ButtonPauseClicked += value;
            }
            remove
            {
                _ButtonPauseClicked -= value;
            }
        }
        #endregion

        #region Methods
        #region Creating controls
        private GroupBox CreateGroupBox(int indexNumber, int rows, int columns)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Size = new Size(GroupBoxWidth, GroupBoxHeight);
            groupBox.Text = String.Format("Ocean {0}", indexNumber);
            groupBox.Name = String.Format("grbxOcean{0}", indexNumber);
            groupBox.BackColor = Color.DarkOliveGreen;
            groupBox.ForeColor = Color.White;
            groupBox.Font = new Font("Sitka Text", FontSizeForLabels);
            groupBox.AllowDrop = true;
            groupBox.Draggable(true);

            AssignGroupBox(groupBox, indexNumber, rows, columns);

            return groupBox;
        }

        private Label CreateLabel(string text, string name, int indexNumber)
        {
            Label label = new Label();
            label.Text = text;
            label.Name = name + indexNumber;
            label.AutoSize = false;
            label.Size = new Size(LabelWidth, LabelHeight);
            label.Font = new Font("Sitka Text", FontSizeForLabels);
            label.ForeColor = Color.White;
            label.BackColor = Color.CornflowerBlue;

            return label;
        }

        private TableLayoutPanelDoubleBuff CreateTableLayoutPanel(int indexNumber, int rows, int columns)
        {
            TableLayoutPanelDoubleBuff tableLayoutPanel = new TableLayoutPanelDoubleBuff();
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.Name = String.Format("tableLayoutPanel{0}", indexNumber);
            tableLayoutPanel.ColumnCount = columns;
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.Size = new Size(TableLayoutPanelWidth, TableLayoutPanelHeight);
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.Visible = false;

            AssignTableLayoutPanelDoubleBuff(tableLayoutPanel, rows, columns);

            return tableLayoutPanel;
        }

        private Button CreateButton(string text, string name, int indexNumber)
        {
            Button button = new Button();
            button.Name = name + indexNumber;
            button.Text = text;
            button.Font = new Font("Sitka Text", FontSizeForButtons);
            button.ForeColor = Color.White;
            button.BackColor = Color.DarkSlateBlue;
            button.Size = new Size(ButtonWidth, ButtonHeight);

            return button;
        }

        private void AssignGroupBox(GroupBox groupBox, int indexNumber, int rows, int columns)
        {
            LblNumberOfIterations = CreateLabel("Iteration number: ", "lblNumberOfIterations", indexNumber);
            AddControl(groupBox, LblNumberOfIterations, new Point(LblIterationsX, LblIterationsY));

            LblNumberOfObstacles = CreateLabel("Obstacles: ", "lblNumberOfObstacles", indexNumber);
            AddControl(groupBox, LblNumberOfObstacles, new Point(LblObstaclesX, LblObstaclesY));

            LblNumberOfPredators = CreateLabel("Predators: ", "lblNumberOfPredators", indexNumber);
            AddControl(groupBox, LblNumberOfPredators, new Point(LblPredatorsX, LblPredatorsY));

            LblNumberOfPrey = CreateLabel("Prey: ", "lblNumberOfPrey", indexNumber);
            AddControl(groupBox, LblNumberOfPrey, new Point(LblPreyX, LblPreyY));

            LblGameState = CreateLabel("", "labelGameState", indexNumber);
            AddControl(groupBox, LblGameState, new Point(LblGameStateX, LblGameStateY));

            TableLayoutPaneltOcean = CreateTableLayoutPanel(indexNumber, rows, columns);
            AddControl(groupBox, TableLayoutPaneltOcean, new Point(TablePanelOceanX, TablePanelOceanY));

            ButtonDelete = CreateButton("Delete", "ButtonDelete", indexNumber);
            ButtonDelete.Click += (object? sender, EventArgs e) => _ButtonDeleteClicked.Invoke(this, EventArgs.Empty);
            AddControl(groupBox, ButtonDelete, new Point(ButtonDeleteX, ButtonDeleteY));

            ButtonPause = CreateButton("Pause", "ButtonPause", indexNumber);
            ButtonPause.Click += (object? sender, EventArgs e) => _ButtonPauseClicked.Invoke(this, EventArgs.Empty);
            AddControl(groupBox, ButtonPause, new Point(ButtonPauseX, ButtonPauseY));

            ButtonResume = CreateButton("Resume", "ButtonResume", indexNumber);
            ButtonResume.Click += (object? sender, EventArgs e) => _ButtonResumeClicked.Invoke(this, EventArgs.Empty);
            AddControl(groupBox, ButtonResume, new Point(ButtonResumeX, ButtonResumeY));
        }

        private void AssignTableLayoutPanelDoubleBuff(TableLayoutPanelDoubleBuff tableLayoutPanel, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tableLayoutPanel.Controls.Add(new PictureBox() { Size = new Size(PBWidth, PBHeight), Name = String.Format("pb{0}{1}", i, j), SizeMode = PictureBoxSizeMode.Zoom }, j, i);
                }
            }
        }

        private void AddControl(Control whereToAdd, Control control, Point point)
        {
            control.Location = point;
            whereToAdd.Controls.Add(control);
        }
        #endregion

        #region Public
        public void Dispose()
        {
            Type type = this.GetType();

            foreach (PropertyInfo propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
            {
                IDisposable disposableProperty = propertyInfo.GetValue(this) as IDisposable;
                disposableProperty.Dispose();
            }
        }
        #endregion

        #endregion
    }
}
