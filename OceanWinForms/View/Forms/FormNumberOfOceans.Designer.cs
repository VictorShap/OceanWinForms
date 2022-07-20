namespace OceanWinForms
{
    partial class FormNumberOfOceans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNumberOfOceans));
            this.lblNumberOfOceans = new System.Windows.Forms.Label();
            this.txtNumberOfOceans = new System.Windows.Forms.TextBox();
            this.btnSubmitNumberOfOceans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberOfOceans
            // 
            this.lblNumberOfOceans.AutoSize = true;
            this.lblNumberOfOceans.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblNumberOfOceans.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfOceans.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumberOfOceans.Location = new System.Drawing.Point(12, 9);
            this.lblNumberOfOceans.Name = "lblNumberOfOceans";
            this.lblNumberOfOceans.Size = new System.Drawing.Size(285, 29);
            this.lblNumberOfOceans.TabIndex = 0;
            this.lblNumberOfOceans.Text = "Enter the number of oceans: ";
            // 
            // txtNumberOfOceans
            // 
            this.txtNumberOfOceans.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtNumberOfOceans.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumberOfOceans.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumberOfOceans.Location = new System.Drawing.Point(315, 5);
            this.txtNumberOfOceans.Name = "txtNumberOfOceans";
            this.txtNumberOfOceans.Size = new System.Drawing.Size(86, 33);
            this.txtNumberOfOceans.TabIndex = 1;
            this.txtNumberOfOceans.Text = "1";
            // 
            // btnSubmitNumberOfOceans
            // 
            this.btnSubmitNumberOfOceans.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmitNumberOfOceans.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitNumberOfOceans.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmitNumberOfOceans.Location = new System.Drawing.Point(276, 62);
            this.btnSubmitNumberOfOceans.Name = "btnSubmitNumberOfOceans";
            this.btnSubmitNumberOfOceans.Size = new System.Drawing.Size(125, 38);
            this.btnSubmitNumberOfOceans.TabIndex = 2;
            this.btnSubmitNumberOfOceans.Text = "Ok";
            this.btnSubmitNumberOfOceans.UseVisualStyleBackColor = false;
            this.btnSubmitNumberOfOceans.Click += new System.EventHandler(this.SubmitNumberOfOceans_Click);
            // 
            // FormNumberOfOceans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OceanWinForms.Properties.Resources.numberOfOceans;
            this.CancelButton = this.btnSubmitNumberOfOceans;
            this.ClientSize = new System.Drawing.Size(403, 107);
            this.Controls.Add(this.btnSubmitNumberOfOceans);
            this.Controls.Add(this.txtNumberOfOceans);
            this.Controls.Add(this.lblNumberOfOceans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNumberOfOceans";
            this.Text = "Number of oceans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumberOfOceans;
        private TextBox txtNumberOfOceans;
        private Button btnSubmitNumberOfOceans;
    }
}