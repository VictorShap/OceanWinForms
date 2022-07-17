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
            this.labelNumberOfOceans = new System.Windows.Forms.Label();
            this.textBoxNumberOfOceans = new System.Windows.Forms.TextBox();
            this.buttonSubmitNumberOfOceans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumberOfOceans
            // 
            this.labelNumberOfOceans.AutoSize = true;
            this.labelNumberOfOceans.Location = new System.Drawing.Point(12, 9);
            this.labelNumberOfOceans.Name = "labelNumberOfOceans";
            this.labelNumberOfOceans.Size = new System.Drawing.Size(191, 20);
            this.labelNumberOfOceans.TabIndex = 0;
            this.labelNumberOfOceans.Text = "Enter the number of oceans";
            // 
            // textBoxNumberOfOceans
            // 
            this.textBoxNumberOfOceans.Location = new System.Drawing.Point(215, 6);
            this.textBoxNumberOfOceans.Name = "textBoxNumberOfOceans";
            this.textBoxNumberOfOceans.Size = new System.Drawing.Size(125, 27);
            this.textBoxNumberOfOceans.TabIndex = 1;
            this.textBoxNumberOfOceans.Text = "1";
            // 
            // buttonSubmitNumberOfOceans
            // 
            this.buttonSubmitNumberOfOceans.Location = new System.Drawing.Point(215, 52);
            this.buttonSubmitNumberOfOceans.Name = "buttonSubmitNumberOfOceans";
            this.buttonSubmitNumberOfOceans.Size = new System.Drawing.Size(125, 29);
            this.buttonSubmitNumberOfOceans.TabIndex = 2;
            this.buttonSubmitNumberOfOceans.Text = "Submit";
            this.buttonSubmitNumberOfOceans.UseVisualStyleBackColor = true;
            this.buttonSubmitNumberOfOceans.Click += new System.EventHandler(this.buttonSubmitNumberOfOceans_Click);
            // 
            // FormNumberOfOceans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 92);
            this.Controls.Add(this.buttonSubmitNumberOfOceans);
            this.Controls.Add(this.textBoxNumberOfOceans);
            this.Controls.Add(this.labelNumberOfOceans);
            this.Name = "FormNumberOfOceans";
            this.Text = "Number of oceans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNumberOfOceans;
        private TextBox textBoxNumberOfOceans;
        private Button buttonSubmitNumberOfOceans;
    }
}