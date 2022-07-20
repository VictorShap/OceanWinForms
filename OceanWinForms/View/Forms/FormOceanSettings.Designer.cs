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
            this.lblNumberOfIterations.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumberOfIterations.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfIterations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberOfIterations.Location = new System.Drawing.Point(12, 186);
            this.lblNumberOfIterations.Name = "lblNumberOfIterations";
            this.lblNumberOfIterations.Size = new System.Drawing.Size(306, 29);
            this.lblNumberOfIterations.TabIndex = 0;
            this.lblNumberOfIterations.Text = "Enter the number of iterations:";
            // 
            // txtNumberOfIterations
            // 
            this.txtNumberOfIterations.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtNumberOfIterations.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumberOfIterations.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumberOfIterations.Location = new System.Drawing.Point(328, 187);
            this.txtNumberOfIterations.Name = "txtNumberOfIterations";
            this.txtNumberOfIterations.Size = new System.Drawing.Size(76, 33);
            this.txtNumberOfIterations.TabIndex = 1;
            this.txtNumberOfIterations.Text = "1000";
            // 
            // txtNumberOfObstacles
            // 
            this.txtNumberOfObstacles.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtNumberOfObstacles.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumberOfObstacles.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumberOfObstacles.Location = new System.Drawing.Point(328, 231);
            this.txtNumberOfObstacles.Name = "txtNumberOfObstacles";
            this.txtNumberOfObstacles.Size = new System.Drawing.Size(76, 33);
            this.txtNumberOfObstacles.TabIndex = 3;
            this.txtNumberOfObstacles.Text = "50";
            // 
            // lblNumberOfObstacles
            // 
            this.lblNumberOfObstacles.AutoSize = true;
            this.lblNumberOfObstacles.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumberOfObstacles.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfObstacles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberOfObstacles.Location = new System.Drawing.Point(12, 234);
            this.lblNumberOfObstacles.Name = "lblNumberOfObstacles";
            this.lblNumberOfObstacles.Size = new System.Drawing.Size(301, 29);
            this.lblNumberOfObstacles.TabIndex = 2;
            this.lblNumberOfObstacles.Text = "Enter the number of obstacles:";
            // 
            // txtNumberOfPredators
            // 
            this.txtNumberOfPredators.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtNumberOfPredators.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumberOfPredators.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumberOfPredators.Location = new System.Drawing.Point(325, 281);
            this.txtNumberOfPredators.Name = "txtNumberOfPredators";
            this.txtNumberOfPredators.Size = new System.Drawing.Size(79, 33);
            this.txtNumberOfPredators.TabIndex = 5;
            this.txtNumberOfPredators.Text = "30";
            // 
            // lblNumberOfPredators
            // 
            this.lblNumberOfPredators.AutoSize = true;
            this.lblNumberOfPredators.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumberOfPredators.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfPredators.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberOfPredators.Location = new System.Drawing.Point(12, 281);
            this.lblNumberOfPredators.Name = "lblNumberOfPredators";
            this.lblNumberOfPredators.Size = new System.Drawing.Size(307, 29);
            this.lblNumberOfPredators.TabIndex = 4;
            this.lblNumberOfPredators.Text = "Enter the number of predators:";
            // 
            // txtNumberOfPrey
            // 
            this.txtNumberOfPrey.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtNumberOfPrey.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumberOfPrey.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumberOfPrey.Location = new System.Drawing.Point(325, 336);
            this.txtNumberOfPrey.Name = "txtNumberOfPrey";
            this.txtNumberOfPrey.Size = new System.Drawing.Size(79, 33);
            this.txtNumberOfPrey.TabIndex = 7;
            this.txtNumberOfPrey.Text = "80";
            // 
            // lblNumberOfPrey
            // 
            this.lblNumberOfPrey.AutoSize = true;
            this.lblNumberOfPrey.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumberOfPrey.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfPrey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberOfPrey.Location = new System.Drawing.Point(12, 332);
            this.lblNumberOfPrey.Name = "lblNumberOfPrey";
            this.lblNumberOfPrey.Size = new System.Drawing.Size(258, 29);
            this.lblNumberOfPrey.TabIndex = 6;
            this.lblNumberOfPrey.Text = "Enter the number of prey:";
            // 
            // lblEnterOceanCoordinates
            // 
            this.lblEnterOceanCoordinates.BackColor = System.Drawing.Color.SteelBlue;
            this.lblEnterOceanCoordinates.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnterOceanCoordinates.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnterOceanCoordinates.Location = new System.Drawing.Point(1, 9);
            this.lblEnterOceanCoordinates.Name = "lblEnterOceanCoordinates";
            this.lblEnterOceanCoordinates.Size = new System.Drawing.Size(403, 66);
            this.lblEnterOceanCoordinates.TabIndex = 10;
            this.lblEnterOceanCoordinates.Text = "Enter the coordinates you want\r\nto position the ocean at:";
            // 
            // txtTopCoordinate
            // 
            this.txtTopCoordinate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtTopCoordinate.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTopCoordinate.ForeColor = System.Drawing.Color.DimGray;
            this.txtTopCoordinate.Location = new System.Drawing.Point(332, 114);
            this.txtTopCoordinate.Name = "txtTopCoordinate";
            this.txtTopCoordinate.Size = new System.Drawing.Size(72, 33);
            this.txtTopCoordinate.TabIndex = 14;
            this.txtTopCoordinate.Text = "150";
            // 
            // txtLeftCoordinate
            // 
            this.txtLeftCoordinate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtLeftCoordinate.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLeftCoordinate.ForeColor = System.Drawing.Color.DimGray;
            this.txtLeftCoordinate.Location = new System.Drawing.Point(112, 114);
            this.txtLeftCoordinate.Name = "txtLeftCoordinate";
            this.txtLeftCoordinate.Size = new System.Drawing.Size(64, 33);
            this.txtLeftCoordinate.TabIndex = 13;
            this.txtLeftCoordinate.Text = "1000";
            // 
            // lblLeftCoorinate
            // 
            this.lblLeftCoorinate.AutoSize = true;
            this.lblLeftCoorinate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblLeftCoorinate.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeftCoorinate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLeftCoorinate.Location = new System.Drawing.Point(12, 114);
            this.lblLeftCoorinate.Name = "lblLeftCoorinate";
            this.lblLeftCoorinate.Size = new System.Drawing.Size(73, 33);
            this.lblLeftCoorinate.TabIndex = 12;
            this.lblLeftCoorinate.Text = "Left: ";
            // 
            // lblTopCoordinate
            // 
            this.lblTopCoordinate.AutoSize = true;
            this.lblTopCoordinate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTopCoordinate.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTopCoordinate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTopCoordinate.Location = new System.Drawing.Point(244, 116);
            this.lblTopCoordinate.Name = "lblTopCoordinate";
            this.lblTopCoordinate.Size = new System.Drawing.Size(69, 33);
            this.lblTopCoordinate.TabIndex = 15;
            this.lblTopCoordinate.Text = "Top: ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStart.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(271, 399);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 49);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.StartOcean_Click);
            // 
            // FormOceanSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OceanWinForms.Properties.Resources.settings;
            this.ClientSize = new System.Drawing.Size(405, 461);
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