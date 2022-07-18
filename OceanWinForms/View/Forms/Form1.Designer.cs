namespace OceanWinForms.View
{
    partial class Form1
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
            this.grbxOcean = new System.Windows.Forms.GroupBox();
            this.lblGameState = new System.Windows.Forms.Label();
            this.txtOcean = new System.Windows.Forms.TextBox();
            this.lblNumberOfPrey = new System.Windows.Forms.Label();
            this.lblNumberOfIterations = new System.Windows.Forms.Label();
            this.lblNumberOfPredators = new System.Windows.Forms.Label();
            this.lblNumberOfObstacles = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbxOcean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbxOcean
            // 
            this.grbxOcean.Controls.Add(this.lblGameState);
            this.grbxOcean.Controls.Add(this.txtOcean);
            this.grbxOcean.Controls.Add(this.lblNumberOfPrey);
            this.grbxOcean.Controls.Add(this.lblNumberOfIterations);
            this.grbxOcean.Controls.Add(this.lblNumberOfPredators);
            this.grbxOcean.Controls.Add(this.lblNumberOfObstacles);
            this.grbxOcean.Location = new System.Drawing.Point(149, 43);
            this.grbxOcean.Name = "grbxOcean";
            this.grbxOcean.Size = new System.Drawing.Size(527, 503);
            this.grbxOcean.TabIndex = 6;
            this.grbxOcean.TabStop = false;
            this.grbxOcean.Text = "Ocean";
            // 
            // lblGameState
            // 
            this.lblGameState.AutoSize = true;
            this.lblGameState.Location = new System.Drawing.Point(20, 467);
            this.lblGameState.Name = "lblGameState";
            this.lblGameState.Size = new System.Drawing.Size(0, 20);
            this.lblGameState.TabIndex = 5;
            // 
            // txtOcean
            // 
            this.txtOcean.Enabled = false;
            this.txtOcean.Location = new System.Drawing.Point(6, 150);
            this.txtOcean.Multiline = true;
            this.txtOcean.Name = "txtOcean";
            this.txtOcean.Size = new System.Drawing.Size(504, 293);
            this.txtOcean.TabIndex = 0;
            // 
            // lblNumberOfPrey
            // 
            this.lblNumberOfPrey.AutoSize = true;
            this.lblNumberOfPrey.Location = new System.Drawing.Point(20, 117);
            this.lblNumberOfPrey.Name = "lblNumberOfPrey";
            this.lblNumberOfPrey.Size = new System.Drawing.Size(44, 20);
            this.lblNumberOfPrey.TabIndex = 4;
            this.lblNumberOfPrey.Text = "Prey: ";
            // 
            // lblNumberOfIterations
            // 
            this.lblNumberOfIterations.AutoSize = true;
            this.lblNumberOfIterations.Location = new System.Drawing.Point(20, 34);
            this.lblNumberOfIterations.Name = "lblNumberOfIterations";
            this.lblNumberOfIterations.Size = new System.Drawing.Size(78, 20);
            this.lblNumberOfIterations.TabIndex = 1;
            this.lblNumberOfIterations.Text = "Iterations: ";
            // 
            // lblNumberOfPredators
            // 
            this.lblNumberOfPredators.AutoSize = true;
            this.lblNumberOfPredators.Location = new System.Drawing.Point(20, 87);
            this.lblNumberOfPredators.Name = "lblNumberOfPredators";
            this.lblNumberOfPredators.Size = new System.Drawing.Size(79, 20);
            this.lblNumberOfPredators.TabIndex = 3;
            this.lblNumberOfPredators.Text = "Predators: ";
            // 
            // lblNumberOfObstacles
            // 
            this.lblNumberOfObstacles.AutoSize = true;
            this.lblNumberOfObstacles.Location = new System.Drawing.Point(20, 59);
            this.lblNumberOfObstacles.Name = "lblNumberOfObstacles";
            this.lblNumberOfObstacles.Size = new System.Drawing.Size(80, 20);
            this.lblNumberOfObstacles.TabIndex = 2;
            this.lblNumberOfObstacles.Text = "Obstacles: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(765, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(765, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 125);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1187, 714);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbxOcean);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbxOcean.ResumeLayout(false);
            this.grbxOcean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GroupBox grbxOcean;
        public Label lblGameState;
        public TextBox txtOcean;
        public Label lblNumberOfPrey;
        public Label lblNumberOfIterations;
        public Label lblNumberOfPredators;
        public Label lblNumberOfObstacles;
        private Button button1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}