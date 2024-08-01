namespace Restaurent.Forms
{
    partial class AboutUsForm
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
            this.AboutUs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutUs
            // 
            this.AboutUs.AutoSize = true;
            this.AboutUs.Font = new System.Drawing.Font("Tahoma", 20F);
            this.AboutUs.Location = new System.Drawing.Point(27, 150);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(600, 48);
            this.AboutUs.TabIndex = 1;
            this.AboutUs.Text = "this will be the form of about us ";
            this.AboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 385);
            this.Controls.Add(this.AboutUs);
            this.Name = "AboutUsForm";
            this.Text = "AboutUsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutUs;
    }
}