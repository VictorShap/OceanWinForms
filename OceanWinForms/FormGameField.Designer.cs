namespace OceanWinForms
{
    partial class FormGameField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOcean = new System.Windows.Forms.TextBox();
            this.labelNumberOfIterations = new System.Windows.Forms.Label();
            this.labelNumberOfObstacles = new System.Windows.Forms.Label();
            this.labelNumberOfPredators = new System.Windows.Forms.Label();
            this.labelNumberOfPrey = new System.Windows.Forms.Label();
            this.groupBoxOcean = new System.Windows.Forms.GroupBox();
            this.labelGameState = new System.Windows.Forms.Label();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.groupBoxOcean.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOcean
            // 
            this.textBoxOcean.Enabled = false;
            this.textBoxOcean.Location = new System.Drawing.Point(6, 150);
            this.textBoxOcean.Multiline = true;
            this.textBoxOcean.Name = "textBoxOcean";
            this.textBoxOcean.Size = new System.Drawing.Size(818, 442);
            this.textBoxOcean.TabIndex = 0;
            // 
            // labelNumberOfIterations
            // 
            this.labelNumberOfIterations.AutoSize = true;
            this.labelNumberOfIterations.Location = new System.Drawing.Point(20, 34);
            this.labelNumberOfIterations.Name = "labelNumberOfIterations";
            this.labelNumberOfIterations.Size = new System.Drawing.Size(78, 20);
            this.labelNumberOfIterations.TabIndex = 1;
            this.labelNumberOfIterations.Text = "Iterations: ";
            // 
            // labelNumberOfObstacles
            // 
            this.labelNumberOfObstacles.AutoSize = true;
            this.labelNumberOfObstacles.Location = new System.Drawing.Point(20, 59);
            this.labelNumberOfObstacles.Name = "labelNumberOfObstacles";
            this.labelNumberOfObstacles.Size = new System.Drawing.Size(80, 20);
            this.labelNumberOfObstacles.TabIndex = 2;
            this.labelNumberOfObstacles.Text = "Obstacles: ";
            // 
            // labelNumberOfPredators
            // 
            this.labelNumberOfPredators.AutoSize = true;
            this.labelNumberOfPredators.Location = new System.Drawing.Point(19, 87);
            this.labelNumberOfPredators.Name = "labelNumberOfPredators";
            this.labelNumberOfPredators.Size = new System.Drawing.Size(79, 20);
            this.labelNumberOfPredators.TabIndex = 3;
            this.labelNumberOfPredators.Text = "Predators: ";
            // 
            // labelNumberOfPrey
            // 
            this.labelNumberOfPrey.AutoSize = true;
            this.labelNumberOfPrey.Location = new System.Drawing.Point(20, 117);
            this.labelNumberOfPrey.Name = "labelNumberOfPrey";
            this.labelNumberOfPrey.Size = new System.Drawing.Size(44, 20);
            this.labelNumberOfPrey.TabIndex = 4;
            this.labelNumberOfPrey.Text = "Prey: ";
            // 
            // groupBoxOcean
            // 
            this.groupBoxOcean.Controls.Add(this.buttonAbort);
            this.groupBoxOcean.Controls.Add(this.labelGameState);
            this.groupBoxOcean.Controls.Add(this.textBoxOcean);
            this.groupBoxOcean.Controls.Add(this.labelNumberOfPrey);
            this.groupBoxOcean.Controls.Add(this.labelNumberOfIterations);
            this.groupBoxOcean.Controls.Add(this.labelNumberOfPredators);
            this.groupBoxOcean.Controls.Add(this.labelNumberOfObstacles);
            this.groupBoxOcean.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOcean.Name = "groupBoxOcean";
            this.groupBoxOcean.Size = new System.Drawing.Size(841, 660);
            this.groupBoxOcean.TabIndex = 5;
            this.groupBoxOcean.TabStop = false;
            this.groupBoxOcean.Text = "Ocean";
            // 
            // labelGameState
            // 
            this.labelGameState.AutoSize = true;
            this.labelGameState.Location = new System.Drawing.Point(19, 607);
            this.labelGameState.Name = "labelGameState";
            this.labelGameState.Size = new System.Drawing.Size(0, 20);
            this.labelGameState.TabIndex = 5;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(670, 615);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(129, 29);
            this.buttonAbort.TabIndex = 6;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // FormGameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 744);
            this.Controls.Add(this.groupBoxOcean);
            this.Name = "FormGameField";
            this.Text = "Game Field";
            this.groupBoxOcean.ResumeLayout(false);
            this.groupBoxOcean.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public TextBox textBoxOcean;
        public Label labelNumberOfIterations;
        public Label labelNumberOfObstacles;
        public Label labelNumberOfPredators;
        public Label labelNumberOfPrey;
        public GroupBox groupBoxOcean;
        public Label labelGameState;
        private Button buttonAbort;
    }
}