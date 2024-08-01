namespace Restaurent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuOfSystem = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.POSTab = new System.Windows.Forms.TabPage();
            this.dataGridViewPOS = new System.Windows.Forms.DataGridView();
            this.ClmnNumberOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControPOSCategories = new System.Windows.Forms.TabControl();
            this.tabFastFood = new System.Windows.Forms.TabPage();
            this.FastFoodflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabTraditionalFood = new System.Windows.Forms.TabPage();
            this.TraditionalflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabDrinks = new System.Windows.Forms.TabPage();
            this.DrinksflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageModernFood = new System.Windows.Forms.TabPage();
            this.ModernFoodflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnClearDataGridVew = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmountPrice = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridProductOperations = new System.Windows.Forms.DataGridView();
            this.ClmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCategoryProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnProductOriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnEditProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClmnRemoveProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnReloadProducts = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MenuOfSystem.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.POSTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOS)).BeginInit();
            this.tabControPOSCategories.SuspendLayout();
            this.tabFastFood.SuspendLayout();
            this.tabTraditionalFood.SuspendLayout();
            this.tabDrinks.SuspendLayout();
            this.tabPageModernFood.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductOperations)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuOfSystem
            // 
            this.MenuOfSystem.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MenuOfSystem.Controls.Add(this.tabPage1);
            this.MenuOfSystem.Controls.Add(this.POSTab);
            this.MenuOfSystem.Controls.Add(this.tabPage3);
            this.MenuOfSystem.Controls.Add(this.tabPage5);
            this.MenuOfSystem.Controls.Add(this.tabPage6);
            this.MenuOfSystem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MenuOfSystem.Location = new System.Drawing.Point(73, -6);
            this.MenuOfSystem.Name = "MenuOfSystem";
            this.MenuOfSystem.SelectedIndex = 0;
            this.MenuOfSystem.Size = new System.Drawing.Size(1236, 644);
            this.MenuOfSystem.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Restaurent.Properties.Resources.Background;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1228, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(523, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // POSTab
            // 
            this.POSTab.BackgroundImage = global::Restaurent.Properties.Resources.Background;
            this.POSTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.POSTab.Controls.Add(this.dataGridViewPOS);
            this.POSTab.Controls.Add(this.tabControPOSCategories);
            this.POSTab.Controls.Add(this.btnSaveBill);
            this.POSTab.Controls.Add(this.button10);
            this.POSTab.Controls.Add(this.btnClearDataGridVew);
            this.POSTab.Controls.Add(this.panel9);
            this.POSTab.Location = new System.Drawing.Point(4, 4);
            this.POSTab.Name = "POSTab";
            this.POSTab.Padding = new System.Windows.Forms.Padding(3);
            this.POSTab.Size = new System.Drawing.Size(1228, 611);
            this.POSTab.TabIndex = 1;
            this.POSTab.Text = "Pos";
            this.POSTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPOS
            // 
            this.dataGridViewPOS.AllowUserToAddRows = false;
            this.dataGridViewPOS.AllowUserToDeleteRows = false;
            this.dataGridViewPOS.AllowUserToResizeColumns = false;
            this.dataGridViewPOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewPOS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPOS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPOS.ColumnHeadersHeight = 34;
            this.dataGridViewPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnNumberOfProduct,
            this.ClmnProductName,
            this.ClmnPrice,
            this.clmnQuantity});
            this.dataGridViewPOS.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewPOS.Location = new System.Drawing.Point(868, 85);
            this.dataGridViewPOS.Name = "dataGridViewPOS";
            this.dataGridViewPOS.RowHeadersVisible = false;
            this.dataGridViewPOS.RowHeadersWidth = 62;
            this.dataGridViewPOS.RowTemplate.Height = 29;
            this.dataGridViewPOS.Size = new System.Drawing.Size(310, 460);
            this.dataGridViewPOS.TabIndex = 0;
            this.dataGridViewPOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPOS_CellContentClick);
            this.dataGridViewPOS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeBill);
            // 
            // ClmnNumberOfProduct
            // 
            this.ClmnNumberOfProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.ClmnNumberOfProduct.DefaultCellStyle = dataGridViewCellStyle9;
            this.ClmnNumberOfProduct.Frozen = true;
            this.ClmnNumberOfProduct.HeaderText = "N°";
            this.ClmnNumberOfProduct.MaxInputLength = 100;
            this.ClmnNumberOfProduct.MinimumWidth = 8;
            this.ClmnNumberOfProduct.Name = "ClmnNumberOfProduct";
            this.ClmnNumberOfProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnNumberOfProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClmnNumberOfProduct.Width = 33;
            // 
            // ClmnProductName
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ClmnProductName.DefaultCellStyle = dataGridViewCellStyle10;
            this.ClmnProductName.Frozen = true;
            this.ClmnProductName.HeaderText = "Product Name";
            this.ClmnProductName.MinimumWidth = 8;
            this.ClmnProductName.Name = "ClmnProductName";
            this.ClmnProductName.Width = 150;
            // 
            // ClmnPrice
            // 
            this.ClmnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.ClmnPrice.DefaultCellStyle = dataGridViewCellStyle11;
            this.ClmnPrice.Frozen = true;
            this.ClmnPrice.HeaderText = "Price";
            this.ClmnPrice.MinimumWidth = 8;
            this.ClmnPrice.Name = "ClmnPrice";
            this.ClmnPrice.Width = 89;
            // 
            // clmnQuantity
            // 
            this.clmnQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.clmnQuantity.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmnQuantity.Frozen = true;
            this.clmnQuantity.HeaderText = "Quantity";
            this.clmnQuantity.MaxInputLength = 20;
            this.clmnQuantity.MinimumWidth = 8;
            this.clmnQuantity.Name = "clmnQuantity";
            this.clmnQuantity.Width = 119;
            // 
            // tabControPOSCategories
            // 
            this.tabControPOSCategories.Controls.Add(this.tabFastFood);
            this.tabControPOSCategories.Controls.Add(this.tabTraditionalFood);
            this.tabControPOSCategories.Controls.Add(this.tabDrinks);
            this.tabControPOSCategories.Controls.Add(this.tabPageModernFood);
            this.tabControPOSCategories.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControPOSCategories.Location = new System.Drawing.Point(148, 54);
            this.tabControPOSCategories.Name = "tabControPOSCategories";
            this.tabControPOSCategories.Padding = new System.Drawing.Point(0, 0);
            this.tabControPOSCategories.SelectedIndex = 0;
            this.tabControPOSCategories.Size = new System.Drawing.Size(685, 625);
            this.tabControPOSCategories.TabIndex = 0;
            // 
            // tabFastFood
            // 
            this.tabFastFood.Controls.Add(this.FastFoodflowLayoutPanel);
            this.tabFastFood.Location = new System.Drawing.Point(4, 35);
            this.tabFastFood.Name = "tabFastFood";
            this.tabFastFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFastFood.Size = new System.Drawing.Size(677, 586);
            this.tabFastFood.TabIndex = 0;
            this.tabFastFood.Text = "Fast Food";
            this.tabFastFood.UseVisualStyleBackColor = true;
            // 
            // FastFoodflowLayoutPanel
            // 
            this.FastFoodflowLayoutPanel.AutoScroll = true;
            this.FastFoodflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FastFoodflowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.FastFoodflowLayoutPanel.Name = "FastFoodflowLayoutPanel";
            this.FastFoodflowLayoutPanel.Size = new System.Drawing.Size(671, 580);
            this.FastFoodflowLayoutPanel.TabIndex = 0;
            // 
            // tabTraditionalFood
            // 
            this.tabTraditionalFood.Controls.Add(this.TraditionalflowLayoutPanel);
            this.tabTraditionalFood.Location = new System.Drawing.Point(4, 35);
            this.tabTraditionalFood.Name = "tabTraditionalFood";
            this.tabTraditionalFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraditionalFood.Size = new System.Drawing.Size(677, 586);
            this.tabTraditionalFood.TabIndex = 1;
            this.tabTraditionalFood.Text = "Traditional Food";
            this.tabTraditionalFood.UseVisualStyleBackColor = true;
            // 
            // TraditionalflowLayoutPanel
            // 
            this.TraditionalflowLayoutPanel.AutoScroll = true;
            this.TraditionalflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TraditionalflowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.TraditionalflowLayoutPanel.Name = "TraditionalflowLayoutPanel";
            this.TraditionalflowLayoutPanel.Size = new System.Drawing.Size(671, 580);
            this.TraditionalflowLayoutPanel.TabIndex = 0;
            // 
            // tabDrinks
            // 
            this.tabDrinks.Controls.Add(this.DrinksflowLayoutPanel);
            this.tabDrinks.Location = new System.Drawing.Point(4, 35);
            this.tabDrinks.Name = "tabDrinks";
            this.tabDrinks.Size = new System.Drawing.Size(677, 586);
            this.tabDrinks.TabIndex = 2;
            this.tabDrinks.Text = "Drinks";
            this.tabDrinks.UseVisualStyleBackColor = true;
            // 
            // DrinksflowLayoutPanel
            // 
            this.DrinksflowLayoutPanel.AutoScroll = true;
            this.DrinksflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrinksflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.DrinksflowLayoutPanel.Name = "DrinksflowLayoutPanel";
            this.DrinksflowLayoutPanel.Size = new System.Drawing.Size(677, 586);
            this.DrinksflowLayoutPanel.TabIndex = 0;
            // 
            // tabPageModernFood
            // 
            this.tabPageModernFood.Controls.Add(this.ModernFoodflowLayoutPanel);
            this.tabPageModernFood.Location = new System.Drawing.Point(4, 35);
            this.tabPageModernFood.Name = "tabPageModernFood";
            this.tabPageModernFood.Size = new System.Drawing.Size(677, 586);
            this.tabPageModernFood.TabIndex = 3;
            this.tabPageModernFood.Text = "Modern Food";
            this.tabPageModernFood.UseVisualStyleBackColor = true;
            // 
            // ModernFoodflowLayoutPanel
            // 
            this.ModernFoodflowLayoutPanel.AutoScroll = true;
            this.ModernFoodflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModernFoodflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ModernFoodflowLayoutPanel.Name = "ModernFoodflowLayoutPanel";
            this.ModernFoodflowLayoutPanel.Size = new System.Drawing.Size(677, 586);
            this.ModernFoodflowLayoutPanel.TabIndex = 0;
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.btnSaveBill.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBill.Location = new System.Drawing.Point(829, 30);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(111, 28);
            this.btnSaveBill.TabIndex = 21;
            this.btnSaveBill.Text = "Save Bill";
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.button10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(974, 29);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 28);
            this.button10.TabIndex = 20;
            this.button10.Text = "Print Bill";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnClearDataGridVew
            // 
            this.btnClearDataGridVew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.btnClearDataGridVew.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDataGridVew.Location = new System.Drawing.Point(1114, 30);
            this.btnClearDataGridVew.Name = "btnClearDataGridVew";
            this.btnClearDataGridVew.Size = new System.Drawing.Size(75, 28);
            this.btnClearDataGridVew.TabIndex = 19;
            this.btnClearDataGridVew.Text = "Clear";
            this.btnClearDataGridVew.UseVisualStyleBackColor = false;
            this.btnClearDataGridVew.Click += new System.EventHandler(this.btnClearDataGridVew_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Snow;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.lblAmountPrice);
            this.panel9.Location = new System.Drawing.Point(868, 579);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(310, 100);
            this.panel9.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total :";
            // 
            // lblAmountPrice
            // 
            this.lblAmountPrice.AutoSize = true;
            this.lblAmountPrice.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.lblAmountPrice.Location = new System.Drawing.Point(68, 28);
            this.lblAmountPrice.Name = "lblAmountPrice";
            this.lblAmountPrice.Size = new System.Drawing.Size(168, 59);
            this.lblAmountPrice.TabIndex = 0;
            this.lblAmountPrice.Text = " 0 DA";
            this.lblAmountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Restaurent.Properties.Resources.Background;
            this.tabPage3.Controls.Add(this.dataGridProductOperations);
            this.tabPage3.Controls.Add(this.btnReloadProducts);
            this.tabPage3.Controls.Add(this.button18);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1228, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridProductOperations
            // 
            this.dataGridProductOperations.AllowUserToOrderColumns = true;
            this.dataGridProductOperations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridProductOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnId,
            this.ClmnNameProduct,
            this.ClmnCategoryProduct,
            this.ClmnProductOriginalPrice,
            this.ClmnSalePrice,
            this.ClmnEditProduct,
            this.ClmnRemoveProduct});
            this.dataGridProductOperations.Location = new System.Drawing.Point(144, 67);
            this.dataGridProductOperations.Name = "dataGridProductOperations";
            this.dataGridProductOperations.RowHeadersVisible = false;
            this.dataGridProductOperations.RowHeadersWidth = 62;
            this.dataGridProductOperations.RowTemplate.Height = 29;
            this.dataGridProductOperations.Size = new System.Drawing.Size(1005, 629);
            this.dataGridProductOperations.TabIndex = 0;
            this.dataGridProductOperations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellOperationDataGridView);
            // 
            // ClmnId
            // 
            this.ClmnId.HeaderText = "ID";
            this.ClmnId.MinimumWidth = 8;
            this.ClmnId.Name = "ClmnId";
            this.ClmnId.ReadOnly = true;
            this.ClmnId.Width = 150;
            // 
            // ClmnNameProduct
            // 
            this.ClmnNameProduct.HeaderText = "Product Name";
            this.ClmnNameProduct.MinimumWidth = 8;
            this.ClmnNameProduct.Name = "ClmnNameProduct";
            this.ClmnNameProduct.ReadOnly = true;
            this.ClmnNameProduct.Width = 150;
            // 
            // ClmnCategoryProduct
            // 
            this.ClmnCategoryProduct.HeaderText = "Category";
            this.ClmnCategoryProduct.MinimumWidth = 8;
            this.ClmnCategoryProduct.Name = "ClmnCategoryProduct";
            this.ClmnCategoryProduct.ReadOnly = true;
            this.ClmnCategoryProduct.Width = 150;
            // 
            // ClmnProductOriginalPrice
            // 
            this.ClmnProductOriginalPrice.HeaderText = "Original Price";
            this.ClmnProductOriginalPrice.MinimumWidth = 8;
            this.ClmnProductOriginalPrice.Name = "ClmnProductOriginalPrice";
            this.ClmnProductOriginalPrice.ReadOnly = true;
            this.ClmnProductOriginalPrice.Width = 150;
            // 
            // ClmnSalePrice
            // 
            this.ClmnSalePrice.HeaderText = "Sale Price";
            this.ClmnSalePrice.MinimumWidth = 8;
            this.ClmnSalePrice.Name = "ClmnSalePrice";
            this.ClmnSalePrice.ReadOnly = true;
            this.ClmnSalePrice.Width = 150;
            // 
            // ClmnEditProduct
            // 
            this.ClmnEditProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClmnEditProduct.HeaderText = "Edit Product";
            this.ClmnEditProduct.Image = global::Restaurent.Properties.Resources.pen_tool;
            this.ClmnEditProduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ClmnEditProduct.MinimumWidth = 8;
            this.ClmnEditProduct.Name = "ClmnEditProduct";
            this.ClmnEditProduct.Width = 110;
            // 
            // ClmnRemoveProduct
            // 
            this.ClmnRemoveProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClmnRemoveProduct.HeaderText = "Remove Product";
            this.ClmnRemoveProduct.Image = global::Restaurent.Properties.Resources.delete;
            this.ClmnRemoveProduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ClmnRemoveProduct.MinimumWidth = 8;
            this.ClmnRemoveProduct.Name = "ClmnRemoveProduct";
            this.ClmnRemoveProduct.Width = 141;
            // 
            // btnReloadProducts
            // 
            this.btnReloadProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.btnReloadProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReloadProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadProducts.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReloadProducts.Location = new System.Drawing.Point(143, 9);
            this.btnReloadProducts.Name = "btnReloadProducts";
            this.btnReloadProducts.Size = new System.Drawing.Size(137, 43);
            this.btnReloadProducts.TabIndex = 17;
            this.btnReloadProducts.Text = "Reload";
            this.btnReloadProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReloadProducts.UseVisualStyleBackColor = false;
            this.btnReloadProducts.Click += new System.EventHandler(this.btnReloadProducts_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(302, 9);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(137, 43);
            this.button18.TabIndex = 16;
            this.button18.Text = "Add Product";
            this.button18.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.AddProductbtn_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::Restaurent.Properties.Resources.Background;
            this.tabPage5.Controls.Add(this.panel3);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Controls.Add(this.panel2);
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1228, 611);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Report";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1228, 611);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Settings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 605);
            this.panel1.TabIndex = 12;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimeLabel.Location = new System.Drawing.Point(33, 74);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(220, 48);
            this.TimeLabel.TabIndex = 22;
            this.TimeLabel.Text = "00:00:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.button8.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(-4, 387);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(219, 42);
            this.button8.TabIndex = 9;
            this.button8.Tag = "5";
            this.button8.Text = "About Us";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.AboutUsClicked);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button7.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 534);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ExitWindow);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.button6.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(-2, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 42);
            this.button6.TabIndex = 6;
            this.button6.Tag = "4";
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ChangeTabIndex);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.button5.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(-2, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 42);
            this.button5.TabIndex = 5;
            this.button5.Tag = "2";
            this.button5.Text = "Products";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ChangeTabIndex);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.button4.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(-2, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 42);
            this.button4.TabIndex = 4;
            this.button4.Tag = "3";
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ChangeTabIndex);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.button2.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(-1, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 42);
            this.button2.TabIndex = 2;
            this.button2.Tag = "1";
            this.button2.Text = "POS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ChangeTabIndex);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.button1.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 42);
            this.button1.TabIndex = 1;
            this.button1.Tag = "0";
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ChangeTabIndex);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Restaurent.Properties.Resources.Supreme;
            this.pictureBox1.Location = new System.Drawing.Point(44, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintBill);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.PrintToFile = true;
            this.printDialog.UseEXDialog = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(181, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 187);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(921, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 187);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(551, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 187);
            this.panel4.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1309, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuOfSystem);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Restaurent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuOfSystem.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.POSTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOS)).EndInit();
            this.tabControPOSCategories.ResumeLayout(false);
            this.tabFastFood.ResumeLayout(false);
            this.tabTraditionalFood.ResumeLayout(false);
            this.tabDrinks.ResumeLayout(false);
            this.tabPageModernFood.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductOperations)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuOfSystem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage POSTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabControl tabControPOSCategories;
        private System.Windows.Forms.TabPage tabFastFood;
        private System.Windows.Forms.TabPage tabTraditionalFood;
        private System.Windows.Forms.TabPage tabDrinks;
        private System.Windows.Forms.TabPage tabPageModernFood;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.FlowLayoutPanel FastFoodflowLayoutPanel;
        private System.Windows.Forms.Button btnClearDataGridVew;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lblAmountPrice;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReloadProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNumberOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQuantity;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        public System.Windows.Forms.DataGridView dataGridViewPOS;
        private System.Windows.Forms.FlowLayoutPanel TraditionalflowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel DrinksflowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ModernFoodflowLayoutPanel;
        private System.Windows.Forms.DataGridView dataGridProductOperations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCategoryProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnProductOriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnSalePrice;
        private System.Windows.Forms.DataGridViewImageColumn ClmnEditProduct;
        private System.Windows.Forms.DataGridViewImageColumn ClmnRemoveProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

