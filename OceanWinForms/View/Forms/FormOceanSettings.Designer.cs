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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOceanSettings));
            this.lblNumberOfIterations = new System.Windows.Forms.Label();
            this.txtNumberOfIterations = new System.Windows.Forms.TextBox();
            this.txtNumberOfObstacles = new System.Windows.Forms.TextBox();
            this.lblNumberOfObstacles = new System.Windows.Forms.Label();
            this.txtNumberOfPredators = new System.Windows.Forms.TextBox();
            this.lblNumberOfPredators = new System.Windows.Forms.Label();
            this.txtNumberOfPrey = new System.Windows.Forms.TextBox();
            this.lblNumberOfPrey = new System.Windows.Forms.Label();
            this.lblEnterOceanCoordinates = new System.Windows.Forms.Label();
            this.txtTopCoordinate = new System.Windows.Forms.TextBox();
            this.txtLeftCoordinate = new System.Windows.Forms.TextBox();
            this.lblLeftCoorinate = new System.Windows.Forms.Label();
            this.lblTopCoordinate = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberOfIterations
            // 
            this.lblNumberOfIterations.AutoSize = true;
            this.lblNumberOfIterations.Location = new System.Drawing.Point(29, 118);
            this.lblNumberOfIterations.Name = "lblNumberOfIterations";
            this.lblNumberOfIterations.Size = new System.Drawing.Size(210, 20);
            this.lblNumberOfIterations.TabIndex = 0;
            this.lblNumberOfIterations.Text = "Enter the number of iterations:";
            // 
            // txtNumberOfIterations
            // 
            this.txtNumberOfIterations.Location = new System.Drawing.Point(261, 115);
            this.txtNumberOfIterations.Name = "txtNumberOfIterations";
            this.txtNumberOfIterations.Size = new System.Drawing.Size(122, 27);
            this.txtNumberOfIterations.TabIndex = 1;
            this.txtNumberOfIterations.Text = "1000";
            // 
            // txtNumberOfObstacles
            // 
            this.txtNumberOfObstacles.Location = new System.Drawing.Point(261, 153);
            this.txtNumberOfObstacles.Name = "txtNumberOfObstacles";
            this.txtNumberOfObstacles.Size = new System.Drawing.Size(122, 27);
            this.txtNumberOfObstacles.TabIndex = 3;
            this.txtNumberOfObstacles.Text = "75";
            // 
            // lblNumberOfObstacles
            // 
            this.lblNumberOfObstacles.AutoSize = true;
            this.lblNumberOfObstacles.Location = new System.Drawing.Point(29, 156);
            this.lblNumberOfObstacles.Name = "lblNumberOfObstacles";
            this.lblNumberOfObstacles.Size = new System.Drawing.Size(210, 20);
            this.lblNumberOfObstacles.TabIndex = 2;
            this.lblNumberOfObstacles.Text = "Enter the number of obstacles:";
            // 
            // txtNumberOfPredators
            // 
            this.txtNumberOfPredators.Location = new System.Drawing.Point(261, 191);
            this.txtNumberOfPredators.Name = "txtNumberOfPredators";
            this.txtNumberOfPredators.Size = new System.Drawing.Size(122, 27);
            this.txtNumberOfPredators.TabIndex = 5;
            this.txtNumberOfPredators.Text = "20";
            // 
            // lblNumberOfPredators
            // 
            this.lblNumberOfPredators.AutoSize = true;
            this.lblNumberOfPredators.Location = new System.Drawing.Point(29, 194);
            this.lblNumberOfPredators.Name = "lblNumberOfPredators";
            this.lblNumberOfPredators.Size = new System.Drawing.Size(212, 20);
            this.lblNumberOfPredators.TabIndex = 4;
            this.lblNumberOfPredators.Text = "Enter the number of predators:";
            // 
            // txtNumberOfPrey
            // 
            this.txtNumberOfPrey.Location = new System.Drawing.Point(261, 228);
            this.txtNumberOfPrey.Name = "txtNumberOfPrey";
            this.txtNumberOfPrey.Size = new System.Drawing.Size(122, 27);
            this.txtNumberOfPrey.TabIndex = 7;
            this.txtNumberOfPrey.Text = "150";
            // 
            // lblNumberOfPrey
            // 
            this.lblNumberOfPrey.AutoSize = true;
            this.lblNumberOfPrey.Location = new System.Drawing.Point(29, 231);
            this.lblNumberOfPrey.Name = "lblNumberOfPrey";
            this.lblNumberOfPrey.Size = new System.Drawing.Size(177, 20);
            this.lblNumberOfPrey.TabIndex = 6;
            this.lblNumberOfPrey.Text = "Enter the number of prey:";
            // 
            // lblEnterOceanCoordinates
            // 
            this.lblEnterOceanCoordinates.AutoSize = true;
            this.lblEnterOceanCoordinates.Location = new System.Drawing.Point(12, 9);
            this.lblEnterOceanCoordinates.Name = "lblEnterOceanCoordinates";
            this.lblEnterOceanCoordinates.Size = new System.Drawing.Size(379, 20);
            this.lblEnterOceanCoordinates.TabIndex = 10;
            this.lblEnterOceanCoordinates.Text = "Enter the coordinates you want to position the ocean at:";
            // 
            // txtTopCoordinate
            // 
            this.txtTopCoordinate.Location = new System.Drawing.Point(283, 49);
            this.txtTopCoordinate.Name = "txtTopCoordinate";
            this.txtTopCoordinate.Size = new System.Drawing.Size(93, 27);
            this.txtTopCoordinate.TabIndex = 14;
            this.txtTopCoordinate.Text = "150";
            // 
            // txtLeftCoordinate
            // 
            this.txtLeftCoordinate.Location = new System.Drawing.Point(85, 49);
            this.txtLeftCoordinate.Name = "txtLeftCoordinate";
            this.txtLeftCoordinate.Size = new System.Drawing.Size(90, 27);
            this.txtLeftCoordinate.TabIndex = 13;
            this.txtLeftCoordinate.Text = "300";
            // 
            // lblLeftCoorinate
            // 
            this.lblLeftCoorinate.AutoSize = true;
            this.lblLeftCoorinate.Location = new System.Drawing.Point(29, 52);
            this.lblLeftCoorinate.Name = "lblLeftCoorinate";
            this.lblLeftCoorinate.Size = new System.Drawing.Size(41, 20);
            this.lblLeftCoorinate.TabIndex = 12;
            this.lblLeftCoorinate.Text = "Left: ";
            // 
            // lblTopCoordinate
            // 
            this.lblTopCoordinate.AutoSize = true;
            this.lblTopCoordinate.Location = new System.Drawing.Point(209, 52);
            this.lblTopCoordinate.Name = "lblTopCoordinate";
            this.lblTopCoordinate.Size = new System.Drawing.Size(41, 20);
            this.lblTopCoordinate.TabIndex = 15;
            this.lblTopCoordinate.Text = "Top: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(261, 271);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 29);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartOcean_Click);
            // 
            // FormOceanSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 311);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTopCoordinate);
            this.Controls.Add(this.txtTopCoordinate);
            this.Controls.Add(this.txtLeftCoordinate);
            this.Controls.Add(this.lblLeftCoorinate);
            this.Controls.Add(this.lblEnterOceanCoordinates);
            this.Controls.Add(this.txtNumberOfPrey);
            this.Controls.Add(this.lblNumberOfPrey);
            this.Controls.Add(this.txtNumberOfPredators);
            this.Controls.Add(this.lblNumberOfPredators);
            this.Controls.Add(this.txtNumberOfObstacles);
            this.Controls.Add(this.lblNumberOfObstacles);
            this.Controls.Add(this.txtNumberOfIterations);
            this.Controls.Add(this.lblNumberOfIterations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOceanSettings";
            this.Text = "Ocean simulation settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblEnterOceanCoordinates;
        private TextBox txtTopCoordinate;
        private TextBox txtLeftCoordinate;
        private Label lblLeftCoorinate;
        private Label lblTopCoordinate;
        private Label lblNumberOfIterations;
        private TextBox txtNumberOfIterations;
        private TextBox txtNumberOfObstacles;
        private Label lblNumberOfObstacles;
        private TextBox txtNumberOfPredators;
        private Label lblNumberOfPredators;
        private TextBox txtNumberOfPrey;
        private Label lblNumberOfPrey;
        private Button btnStart;
    }
}