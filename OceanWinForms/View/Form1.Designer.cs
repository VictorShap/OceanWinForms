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
            this.grbxOcean.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 714);
            this.Controls.Add(this.grbxOcean);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbxOcean.ResumeLayout(false);
            this.grbxOcean.PerformLayout();
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
    }
}