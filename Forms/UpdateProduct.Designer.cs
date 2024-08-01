namespace Restaurent.Forms
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ProductOriginalPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductSalePriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nafees Web Naskh", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "Product Image";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProductImage);
            this.panel1.Location = new System.Drawing.Point(475, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 188);
            this.panel1.TabIndex = 20;
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Items.AddRange(new object[] {
            "Fast Food",
            "Traditional Food",
            "Modern Food",
            "Drinks"});
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(191, 101);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(213, 27);
            this.ProductCategoryComboBox.TabIndex = 19;
            // 
            // ProductOriginalPriceTextBox
            // 
            this.ProductOriginalPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductOriginalPriceTextBox.Location = new System.Drawing.Point(191, 151);
            this.ProductOriginalPriceTextBox.Name = "ProductOriginalPriceTextBox";
            this.ProductOriginalPriceTextBox.Size = new System.Drawing.Size(213, 27);
            this.ProductOriginalPriceTextBox.TabIndex = 18;
            // 
            // ProductSalePriceTextBox
            // 
            this.ProductSalePriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductSalePriceTextBox.Location = new System.Drawing.Point(191, 198);
            this.ProductSalePriceTextBox.Name = "ProductSalePriceTextBox";
            this.ProductSalePriceTextBox.Size = new System.Drawing.Size(213, 27);
            this.ProductSalePriceTextBox.TabIndex = 17;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductNameTextBox.Location = new System.Drawing.Point(191, 55);
            this.ProductNameTextBox.MaxLength = 3000;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(213, 27);
            this.ProductNameTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Original Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sale Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name";
            // 
            // ProductImage
            // 
            this.ProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductImage.Location = new System.Drawing.Point(0, 0);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(146, 188);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            this.ProductImage.Click += new System.EventHandler(this.ProductImage_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(376, 296);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 41);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.OkButton.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(513, 296);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(115, 41);
            this.OkButton.TabIndex = 22;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 349);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductCategoryComboBox);
            this.Controls.Add(this.ProductOriginalPriceTextBox);
            this.Controls.Add(this.ProductSalePriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.TextBox ProductOriginalPriceTextBox;
        private System.Windows.Forms.TextBox ProductSalePriceTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}