namespace OceanWinForms
{
    partial class FormOceanSettings : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumberOfIterations = new System.Windows.Forms.Label();
            this.textBoxNumberOfIterations = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfObstacles = new System.Windows.Forms.TextBox();
            this.labelNumberOfObstacles = new System.Windows.Forms.Label();
            this.textBoxNumberOfPredators = new System.Windows.Forms.TextBox();
            this.labelNumberOfPredators = new System.Windows.Forms.Label();
            this.textBoxNumberOfPrey = new System.Windows.Forms.TextBox();
            this.labelNumberOfPrey = new System.Windows.Forms.Label();
            this.labelEnterOceanCoordinates = new System.Windows.Forms.Label();
            this.textBoxTopCoordinate = new System.Windows.Forms.TextBox();
            this.textBoxLeftCoordinate = new System.Windows.Forms.TextBox();
            this.labelLeftCoorinate = new System.Windows.Forms.Label();
            this.labelTopCoordinate = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumberOfIterations
            // 
            this.labelNumberOfIterations.AutoSize = true;
            this.labelNumberOfIterations.Location = new System.Drawing.Point(29, 118);
            this.labelNumberOfIterations.Name = "labelNumberOfIterations";
            this.labelNumberOfIterations.Size = new System.Drawing.Size(210, 20);
            this.labelNumberOfIterations.TabIndex = 0;
            this.labelNumberOfIterations.Text = "Enter the number of iterations:";
            // 
            // textBoxNumberOfIterations
            // 
            this.textBoxNumberOfIterations.Location = new System.Drawing.Point(261, 115);
            this.textBoxNumberOfIterations.Name = "textBoxNumberOfIterations";
            this.textBoxNumberOfIterations.Size = new System.Drawing.Size(122, 27);
            this.textBoxNumberOfIterations.TabIndex = 1;
            this.textBoxNumberOfIterations.Text = "1000";
            // 
            // textBoxNumberOfObstacles
            // 
            this.textBoxNumberOfObstacles.Location = new System.Drawing.Point(261, 153);
            this.textBoxNumberOfObstacles.Name = "textBoxNumberOfObstacles";
            this.textBoxNumberOfObstacles.Size = new System.Drawing.Size(122, 27);
            this.textBoxNumberOfObstacles.TabIndex = 3;
            this.textBoxNumberOfObstacles.Text = "75";
            // 
            // labelNumberOfObstacles
            // 
            this.labelNumberOfObstacles.AutoSize = true;
            this.labelNumberOfObstacles.Location = new System.Drawing.Point(29, 156);
            this.labelNumberOfObstacles.Name = "labelNumberOfObstacles";
            this.labelNumberOfObstacles.Size = new System.Drawing.Size(210, 20);
            this.labelNumberOfObstacles.TabIndex = 2;
            this.labelNumberOfObstacles.Text = "Enter the number of obstacles:";
            // 
            // textBoxNumberOfPredators
            // 
            this.textBoxNumberOfPredators.Location = new System.Drawing.Point(261, 191);
            this.textBoxNumberOfPredators.Name = "textBoxNumberOfPredators";
            this.textBoxNumberOfPredators.Size = new System.Drawing.Size(122, 27);
            this.textBoxNumberOfPredators.TabIndex = 5;
            this.textBoxNumberOfPredators.Text = "20";
            // 
            // labelNumberOfPredators
            // 
            this.labelNumberOfPredators.AutoSize = true;
            this.labelNumberOfPredators.Location = new System.Drawing.Point(29, 194);
            this.labelNumberOfPredators.Name = "labelNumberOfPredators";
            this.labelNumberOfPredators.Size = new System.Drawing.Size(212, 20);
            this.labelNumberOfPredators.TabIndex = 4;
            this.labelNumberOfPredators.Text = "Enter the number of predators:";
            // 
            // textBoxNumberOfPrey
            // 
            this.textBoxNumberOfPrey.Location = new System.Drawing.Point(261, 228);
            this.textBoxNumberOfPrey.Name = "textBoxNumberOfPrey";
            this.textBoxNumberOfPrey.Size = new System.Drawing.Size(122, 27);
            this.textBoxNumberOfPrey.TabIndex = 7;
            this.textBoxNumberOfPrey.Text = "150";
            // 
            // labelNumberOfPrey
            // 
            this.labelNumberOfPrey.AutoSize = true;
            this.labelNumberOfPrey.Location = new System.Drawing.Point(29, 231);
            this.labelNumberOfPrey.Name = "labelNumberOfPrey";
            this.labelNumberOfPrey.Size = new System.Drawing.Size(177, 20);
            this.labelNumberOfPrey.TabIndex = 6;
            this.labelNumberOfPrey.Text = "Enter the number of prey:";
            // 
            // labelEnterOceanCoordinates
            // 
            this.labelEnterOceanCoordinates.AutoSize = true;
            this.labelEnterOceanCoordinates.Location = new System.Drawing.Point(12, 9);
            this.labelEnterOceanCoordinates.Name = "labelEnterOceanCoordinates";
            this.labelEnterOceanCoordinates.Size = new System.Drawing.Size(379, 20);
            this.labelEnterOceanCoordinates.TabIndex = 10;
            this.labelEnterOceanCoordinates.Text = "Enter the coordinates you want to position the ocean at:";
            // 
            // textBoxTopCoordinate
            // 
            this.textBoxTopCoordinate.Location = new System.Drawing.Point(293, 49);
            this.textBoxTopCoordinate.Name = "textBoxTopCoordinate";
            this.textBoxTopCoordinate.Size = new System.Drawing.Size(90, 27);
            this.textBoxTopCoordinate.TabIndex = 14;
            this.textBoxTopCoordinate.Text = "150";
            // 
            // textBoxLeftCoordinate
            // 
            this.textBoxLeftCoordinate.Location = new System.Drawing.Point(85, 49);
            this.textBoxLeftCoordinate.Name = "textBoxLeftCoordinate";
            this.textBoxLeftCoordinate.Size = new System.Drawing.Size(90, 27);
            this.textBoxLeftCoordinate.TabIndex = 13;
            this.textBoxLeftCoordinate.Text = "300";
            // 
            // labelLeftCoorinate
            // 
            this.labelLeftCoorinate.AutoSize = true;
            this.labelLeftCoorinate.Location = new System.Drawing.Point(29, 52);
            this.labelLeftCoorinate.Name = "labelLeftCoorinate";
            this.labelLeftCoorinate.Size = new System.Drawing.Size(41, 20);
            this.labelLeftCoorinate.TabIndex = 12;
            this.labelLeftCoorinate.Text = "Left: ";
            // 
            // labelTopCoordinate
            // 
            this.labelTopCoordinate.AutoSize = true;
            this.labelTopCoordinate.Location = new System.Drawing.Point(233, 52);
            this.labelTopCoordinate.Name = "labelTopCoordinate";
            this.labelTopCoordinate.Size = new System.Drawing.Size(41, 20);
            this.labelTopCoordinate.TabIndex = 15;
            this.labelTopCoordinate.Text = "Top: ";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(261, 271);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(122, 29);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.StartOcean_Click);
            // 
            // FormOceanSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 311);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTopCoordinate);
            this.Controls.Add(this.textBoxTopCoordinate);
            this.Controls.Add(this.textBoxLeftCoordinate);
            this.Controls.Add(this.labelLeftCoorinate);
            this.Controls.Add(this.labelEnterOceanCoordinates);
            this.Controls.Add(this.textBoxNumberOfPrey);
            this.Controls.Add(this.labelNumberOfPrey);
            this.Controls.Add(this.textBoxNumberOfPredators);
            this.Controls.Add(this.labelNumberOfPredators);
            this.Controls.Add(this.textBoxNumberOfObstacles);
            this.Controls.Add(this.labelNumberOfObstacles);
            this.Controls.Add(this.textBoxNumberOfIterations);
            this.Controls.Add(this.labelNumberOfIterations);
            this.Name = "FormOceanSettings";
            this.Text = "Ocean simulation settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelEnterOceanCoordinates;
        private TextBox textBoxTopCoordinate;
        private TextBox textBoxLeftCoordinate;
        private Label labelLeftCoorinate;
        private Label labelTopCoordinate;
        private Label labelNumberOfIterations;
        private TextBox textBoxNumberOfIterations;
        private TextBox textBoxNumberOfObstacles;
        private Label labelNumberOfObstacles;
        private TextBox textBoxNumberOfPredators;
        private Label labelNumberOfPredators;
        private TextBox textBoxNumberOfPrey;
        private Label labelNumberOfPrey;
        private Button buttonStart;
    }
}