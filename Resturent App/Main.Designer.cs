namespace Resturent_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ResturentLogoName = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Admin = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.MainPageCenterPannel = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaBarDataset1 = new Guna.Charts.WinForms.GunaBarDataset();
            this.Foodpicture = new System.Windows.Forms.PictureBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DashBoardButton = new Guna.UI2.WinForms.Guna2Button();
            this.picturLogo = new System.Windows.Forms.PictureBox();
            this.labelDashBoard = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.MainPageCenterPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foodpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.guna2Button5);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.DashBoardButton);
            this.guna2Panel1.Controls.Add(this.ResturentLogoName);
            this.guna2Panel1.Controls.Add(this.picturLogo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(293, 956);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ResturentLogoName
            // 
            this.ResturentLogoName.AutoSize = true;
            this.ResturentLogoName.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturentLogoName.Location = new System.Drawing.Point(61, 119);
            this.ResturentLogoName.Name = "ResturentLogoName";
            this.ResturentLogoName.Size = new System.Drawing.Size(169, 33);
            this.ResturentLogoName.TabIndex = 1;
            this.ResturentLogoName.Text = "Resturent App";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Controls.Add(this.labelDashBoard);
            this.guna2Panel2.Controls.Add(this.Admin);
            this.guna2Panel2.Controls.Add(this.UserName);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(293, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1501, 66);
            this.guna2Panel2.TabIndex = 1;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold);
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(1418, 18);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(71, 21);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold);
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(1289, 18);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(110, 21);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name";
            // 
            // MainPageCenterPannel
            // 
            this.MainPageCenterPannel.Controls.Add(this.Foodpicture);
            this.MainPageCenterPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageCenterPannel.Location = new System.Drawing.Point(293, 0);
            this.MainPageCenterPannel.Name = "MainPageCenterPannel";
            this.MainPageCenterPannel.Size = new System.Drawing.Size(1501, 956);
            this.MainPageCenterPannel.TabIndex = 1;
            this.MainPageCenterPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPageCenterPannel_Paint);
            // 
            // gunaBarDataset1
            // 
            this.gunaBarDataset1.Label = "Bar1";
            // 
            // Foodpicture
            // 
            this.Foodpicture.Image = global::Resturent_App.Properties.Resources.pngwing_com;
            this.Foodpicture.Location = new System.Drawing.Point(258, 119);
            this.Foodpicture.Name = "Foodpicture";
            this.Foodpicture.Size = new System.Drawing.Size(1000, 650);
            this.Foodpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foodpicture.TabIndex = 0;
            this.Foodpicture.TabStop = false;
            this.Foodpicture.WaitOnLoad = true;
            this.Foodpicture.Click += new System.EventHandler(this.Foodpicture_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::Resturent_App.Properties.Resources.restaurant__2_;
            this.guna2Button5.Location = new System.Drawing.Point(2, 246);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(288, 61);
            this.guna2Button5.TabIndex = 7;
            this.guna2Button5.Text = "   Food Categories";
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::Resturent_App.Properties.Resources.user__2_1;
            this.guna2Button4.Location = new System.Drawing.Point(5, 311);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(288, 61);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "   Employee Stuff";
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::Resturent_App.Properties.Resources.cutlery;
            this.guna2Button3.Location = new System.Drawing.Point(5, 446);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(288, 61);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "   Reports";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Resturent_App.Properties.Resources.settings;
            this.guna2Button2.Location = new System.Drawing.Point(5, 513);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(288, 61);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "   Settings";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Resturent_App.Properties.Resources.menu;
            this.guna2Button1.Location = new System.Drawing.Point(5, 379);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(288, 61);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "   Products";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DashBoardButton
            // 
            this.DashBoardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashBoardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashBoardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashBoardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashBoardButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardButton.ForeColor = System.Drawing.Color.White;
            this.DashBoardButton.Image = global::Resturent_App.Properties.Resources.restaurant;
            this.DashBoardButton.Location = new System.Drawing.Point(5, 178);
            this.DashBoardButton.Name = "DashBoardButton";
            this.DashBoardButton.Size = new System.Drawing.Size(288, 61);
            this.DashBoardButton.TabIndex = 2;
            this.DashBoardButton.Text = "   Dash board";
            this.DashBoardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // picturLogo
            // 
            this.picturLogo.Image = global::Resturent_App.Properties.Resources.restaurant__3_;
            this.picturLogo.Location = new System.Drawing.Point(94, 12);
            this.picturLogo.Name = "picturLogo";
            this.picturLogo.Size = new System.Drawing.Size(102, 91);
            this.picturLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturLogo.TabIndex = 0;
            this.picturLogo.TabStop = false;
            // 
            // labelDashBoard
            // 
            this.labelDashBoard.AutoSize = true;
            this.labelDashBoard.Font = new System.Drawing.Font("Impact", 12F);
            this.labelDashBoard.ForeColor = System.Drawing.Color.White;
            this.labelDashBoard.Location = new System.Drawing.Point(23, 18);
            this.labelDashBoard.Name = "labelDashBoard";
            this.labelDashBoard.Size = new System.Drawing.Size(124, 29);
            this.labelDashBoard.TabIndex = 2;
            this.labelDashBoard.Text = "Dash Board";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1794, 956);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.MainPageCenterPannel);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1816, 820);
            this.Name = "MainForm";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.MainPageCenterPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foodpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel MainPageCenterPannel;
        private Guna.Charts.WinForms.GunaBarDataset gunaBarDataset1;
        private System.Windows.Forms.PictureBox picturLogo;
        private System.Windows.Forms.Label ResturentLogoName;
        private Guna.UI2.WinForms.Guna2Button DashBoardButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.PictureBox Foodpicture;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label labelDashBoard;
    }
}