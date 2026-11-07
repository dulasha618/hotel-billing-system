namespace Hotel_Billing_System.Froms
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOramt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblorChg = new System.Windows.Forms.Label();
            this.lblorPrz = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrReceipt = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrpay = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrdersave = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnClr = new Guna.UI2.WinForms.Guna2Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblProId = new System.Windows.Forms.Label();
            this.comboBoxPid = new System.Windows.Forms.ComboBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.lblPricers = new System.Windows.Forms.Label();
            this.lblProductname = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDataProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeshopmanagemantsystemDataSet4 = new Hotel_Billing_System.cafeshopmanagemantsystemDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.cafeshopmanagemantsystemDataSet1 = new Hotel_Billing_System.cafeshopmanagemantsystemDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Hotel_Billing_System.cafeshopmanagemantsystemDataSet1TableAdapters.productTableAdapter();
            this.productTableAdapter1 = new Hotel_Billing_System.cafeshopmanagemantsystemDataSet4TableAdapters.productTableAdapter();
            this.pridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrRecipt = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeshopmanagemantsystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeshopmanagemantsystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrRecipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvOrRecipt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOramt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblorChg);
            this.panel1.Controls.Add(this.lblorPrz);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnOrReceipt);
            this.panel1.Controls.Add(this.btnOrpay);
            this.panel1.Controls.Add(this.btnOrdersave);
            this.panel1.Location = new System.Drawing.Point(547, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 472);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Change(RS) :";
            // 
            // txtOramt
            // 
            this.txtOramt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOramt.Location = new System.Drawing.Point(148, 310);
            this.txtOramt.Margin = new System.Windows.Forms.Padding(2);
            this.txtOramt.Name = "txtOramt";
            this.txtOramt.Size = new System.Drawing.Size(76, 20);
            this.txtOramt.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Amount(RS) :";
            // 
            // lblorChg
            // 
            this.lblorChg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblorChg.AutoSize = true;
            this.lblorChg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorChg.Location = new System.Drawing.Point(145, 343);
            this.lblorChg.Name = "lblorChg";
            this.lblorChg.Size = new System.Drawing.Size(31, 15);
            this.lblorChg.TabIndex = 24;
            this.lblorChg.Text = "0.00";
            // 
            // lblorPrz
            // 
            this.lblorPrz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblorPrz.AutoSize = true;
            this.lblorPrz.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorPrz.Location = new System.Drawing.Point(145, 281);
            this.lblorPrz.Name = "lblorPrz";
            this.lblorPrz.Size = new System.Drawing.Size(31, 15);
            this.lblorPrz.TabIndex = 25;
            this.lblorPrz.Text = "0.00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Price (RS) :";
            // 
            // btnOrReceipt
            // 
            this.btnOrReceipt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrReceipt.BorderRadius = 15;
            this.btnOrReceipt.CheckedState.Parent = this.btnOrReceipt;
            this.btnOrReceipt.CustomImages.Parent = this.btnOrReceipt;
            this.btnOrReceipt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrReceipt.ForeColor = System.Drawing.Color.White;
            this.btnOrReceipt.HoverState.Parent = this.btnOrReceipt;
            this.btnOrReceipt.Location = new System.Drawing.Point(141, 413);
            this.btnOrReceipt.Name = "btnOrReceipt";
            this.btnOrReceipt.ShadowDecoration.Parent = this.btnOrReceipt;
            this.btnOrReceipt.Size = new System.Drawing.Size(82, 33);
            this.btnOrReceipt.TabIndex = 21;
            this.btnOrReceipt.Text = "Receipt";
            this.btnOrReceipt.Click += new System.EventHandler(this.btnOrReceipt_Click);
            // 
            // btnOrpay
            // 
            this.btnOrpay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrpay.BorderRadius = 15;
            this.btnOrpay.CheckedState.Parent = this.btnOrpay;
            this.btnOrpay.CustomImages.Parent = this.btnOrpay;
            this.btnOrpay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrpay.ForeColor = System.Drawing.Color.White;
            this.btnOrpay.HoverState.Parent = this.btnOrpay;
            this.btnOrpay.Location = new System.Drawing.Point(25, 413);
            this.btnOrpay.Name = "btnOrpay";
            this.btnOrpay.ShadowDecoration.Parent = this.btnOrpay;
            this.btnOrpay.Size = new System.Drawing.Size(82, 33);
            this.btnOrpay.TabIndex = 21;
            this.btnOrpay.Text = "Pay";
            this.btnOrpay.Click += new System.EventHandler(this.btnOrpay_Click);
            // 
            // btnOrdersave
            // 
            this.btnOrdersave.BorderRadius = 15;
            this.btnOrdersave.CheckedState.Parent = this.btnOrdersave;
            this.btnOrdersave.CustomImages.Parent = this.btnOrdersave;
            this.btnOrdersave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrdersave.ForeColor = System.Drawing.Color.White;
            this.btnOrdersave.HoverState.Parent = this.btnOrdersave;
            this.btnOrdersave.Location = new System.Drawing.Point(-117, 414);
            this.btnOrdersave.Name = "btnOrdersave";
            this.btnOrdersave.ShadowDecoration.Parent = this.btnOrdersave;
            this.btnOrdersave.Size = new System.Drawing.Size(82, 33);
            this.btnOrdersave.TabIndex = 21;
            this.btnOrdersave.Text = "Save";
            // 
            // btnOrAdd
            // 
            this.btnOrAdd.BorderRadius = 15;
            this.btnOrAdd.CheckedState.Parent = this.btnOrAdd;
            this.btnOrAdd.CustomImages.Parent = this.btnOrAdd;
            this.btnOrAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrAdd.ForeColor = System.Drawing.Color.White;
            this.btnOrAdd.HoverState.Parent = this.btnOrAdd;
            this.btnOrAdd.Location = new System.Drawing.Point(38, 167);
            this.btnOrAdd.Name = "btnOrAdd";
            this.btnOrAdd.ShadowDecoration.Parent = this.btnOrAdd;
            this.btnOrAdd.Size = new System.Drawing.Size(82, 33);
            this.btnOrAdd.TabIndex = 21;
            this.btnOrAdd.Text = "Add";
            this.btnOrAdd.Click += new System.EventHandler(this.btnOrAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 15;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(230, 167);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(82, 33);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.comboBoxType);
            this.panel3.Controls.Add(this.btnOrAdd);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnClr);
            this.panel3.Controls.Add(this.lblQty);
            this.panel3.Controls.Add(this.lblProId);
            this.panel3.Controls.Add(this.comboBoxPid);
            this.panel3.Controls.Add(this.lblPname);
            this.panel3.Controls.Add(this.lblPricers);
            this.panel3.Controls.Add(this.lblProductname);
            this.panel3.Controls.Add(this.lblType);
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Location = new System.Drawing.Point(9, 256);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 227);
            this.panel3.TabIndex = 0;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(157, 50);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(92, 21);
            this.comboBoxType.TabIndex = 38;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(423, 87);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(76, 20);
            this.txtQty.TabIndex = 36;
            // 
            // btnClr
            // 
            this.btnClr.BorderRadius = 15;
            this.btnClr.CheckedState.Parent = this.btnClr;
            this.btnClr.CustomImages.Parent = this.btnClr;
            this.btnClr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClr.ForeColor = System.Drawing.Color.White;
            this.btnClr.HoverState.Parent = this.btnClr;
            this.btnClr.Location = new System.Drawing.Point(423, 167);
            this.btnClr.Name = "btnClr";
            this.btnClr.ShadowDecoration.Parent = this.btnClr;
            this.btnClr.Size = new System.Drawing.Size(82, 33);
            this.btnClr.TabIndex = 21;
            this.btnClr.Text = "Clear";
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(344, 87);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(62, 15);
            this.lblQty.TabIndex = 24;
            this.lblQty.Text = "Quantity :";
            // 
            // lblProId
            // 
            this.lblProId.AutoSize = true;
            this.lblProId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProId.Location = new System.Drawing.Point(346, 52);
            this.lblProId.Name = "lblProId";
            this.lblProId.Size = new System.Drawing.Size(73, 15);
            this.lblProId.TabIndex = 25;
            this.lblProId.Text = "Product ID :";
            // 
            // comboBoxPid
            // 
            this.comboBoxPid.FormattingEnabled = true;
            this.comboBoxPid.Location = new System.Drawing.Point(423, 50);
            this.comboBoxPid.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPid.Name = "comboBoxPid";
            this.comboBoxPid.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPid.TabIndex = 37;
            this.comboBoxPid.SelectedIndexChanged += new System.EventHandler(this.comboBoxPid_SelectedIndexChanged);
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPname.Location = new System.Drawing.Point(43, 87);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(91, 15);
            this.lblPname.TabIndex = 29;
            this.lblPname.Text = "Product Name :";
            // 
            // lblPricers
            // 
            this.lblPricers.AutoSize = true;
            this.lblPricers.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricers.Location = new System.Drawing.Point(43, 124);
            this.lblPricers.Name = "lblPricers";
            this.lblPricers.Size = new System.Drawing.Size(69, 15);
            this.lblPricers.TabIndex = 28;
            this.lblPricers.Text = "Price(RS) :";
            // 
            // lblProductname
            // 
            this.lblProductname.AutoSize = true;
            this.lblProductname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductname.Location = new System.Drawing.Point(154, 87);
            this.lblProductname.Name = "lblProductname";
            this.lblProductname.Size = new System.Drawing.Size(0, 15);
            this.lblProductname.TabIndex = 26;
            this.lblProductname.Click += new System.EventHandler(this.lblProductname_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(43, 50);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 15);
            this.lblType.TabIndex = 34;
            this.lblType.Text = "Type:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(154, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 15);
            this.lblPrice.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvDataProduct);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 231);
            this.panel2.TabIndex = 0;
            // 
            // dgvDataProduct
            // 
            this.dgvDataProduct.AllowUserToAddRows = false;
            this.dgvDataProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvDataProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDataProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataProduct.AutoGenerateColumns = false;
            this.dgvDataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDataProduct.ColumnHeadersHeight = 25;
            this.dgvDataProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pridDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn1,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1});
            this.dgvDataProduct.DataSource = this.productBindingSource1;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataProduct.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDataProduct.EnableHeadersVisualStyles = false;
            this.dgvDataProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataProduct.Location = new System.Drawing.Point(16, 29);
            this.dgvDataProduct.MaximumSize = new System.Drawing.Size(1300, 600);
            this.dgvDataProduct.Name = "dgvDataProduct";
            this.dgvDataProduct.ReadOnly = true;
            this.dgvDataProduct.RowHeadersVisible = false;
            this.dgvDataProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataProduct.Size = new System.Drawing.Size(501, 193);
            this.dgvDataProduct.TabIndex = 23;
            this.dgvDataProduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDataProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDataProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDataProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDataProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDataProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDataProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDataProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDataProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDataProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDataProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDataProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDataProduct.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvDataProduct.ThemeStyle.ReadOnly = true;
            this.dgvDataProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDataProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDataProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDataProduct.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDataProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDataProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataProduct_CellContentClick);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.cafeshopmanagemantsystemDataSet4;
            // 
            // cafeshopmanagemantsystemDataSet4
            // 
            this.cafeshopmanagemantsystemDataSet4.DataSetName = "cafeshopmanagemantsystemDataSet4";
            this.cafeshopmanagemantsystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Menu";
            // 
            // cafeshopmanagemantsystemDataSet1
            // 
            this.cafeshopmanagemantsystemDataSet1.DataSetName = "cafeshopmanagemantsystemDataSet1";
            this.cafeshopmanagemantsystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.cafeshopmanagemantsystemDataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // pridDataGridViewTextBoxColumn
            // 
            this.pridDataGridViewTextBoxColumn.DataPropertyName = "prid";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pridDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.pridDataGridViewTextBoxColumn.HeaderText = "Pr#";
            this.pridDataGridViewTextBoxColumn.Name = "pridDataGridViewTextBoxColumn";
            this.pridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn1
            // 
            this.productnameDataGridViewTextBoxColumn1.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn1.Name = "productnameDataGridViewTextBoxColumn1";
            this.productnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvOrRecipt
            // 
            this.dgvOrRecipt.AllowUserToAddRows = false;
            this.dgvOrRecipt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvOrRecipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrRecipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrRecipt.AutoGenerateColumns = false;
            this.dgvOrRecipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvOrRecipt.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrRecipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrRecipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrRecipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrRecipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOrRecipt.ColumnHeadersHeight = 21;
            this.dgvOrRecipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvOrRecipt.DataSource = this.receiptBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrRecipt.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvOrRecipt.EnableHeadersVisualStyles = false;
            this.dgvOrRecipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrRecipt.Location = new System.Drawing.Point(8, 11);
            this.dgvOrRecipt.MaximumSize = new System.Drawing.Size(1300, 600);
            this.dgvOrRecipt.MultiSelect = false;
            this.dgvOrRecipt.Name = "dgvOrRecipt";
            this.dgvOrRecipt.ReadOnly = true;
            this.dgvOrRecipt.RowHeadersVisible = false;
            this.dgvOrRecipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOrRecipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrRecipt.Size = new System.Drawing.Size(237, 193);
            this.dgvOrRecipt.TabIndex = 28;
            this.dgvOrRecipt.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvOrRecipt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrRecipt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrRecipt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrRecipt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrRecipt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrRecipt.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrRecipt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrRecipt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOrRecipt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrRecipt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvOrRecipt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrRecipt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrRecipt.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvOrRecipt.ThemeStyle.ReadOnly = true;
            this.dgvOrRecipt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrRecipt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrRecipt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvOrRecipt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrRecipt.ThemeStyle.RowsStyle.Height = 22;
            this.dgvOrRecipt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrRecipt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 98.98648F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 46;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.FillWeight = 101.36F;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 116;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 99.05264F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 61;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 101.4447F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 86;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 99.15612F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 61;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(Hotel_Billing_System.Receipt);
            this.receiptBindingSource.CurrentChanged += new System.EventHandler(this.receiptBindingSource_CurrentChanged);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeshopmanagemantsystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeshopmanagemantsystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrRecipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOramt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblorChg;
        private System.Windows.Forms.Label lblorPrz;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnOrReceipt;
        private Guna.UI2.WinForms.Guna2Button btnOrpay;
        private Guna.UI2.WinForms.Guna2Button btnOrdersave;
        private Guna.UI2.WinForms.Guna2Button btnOrAdd;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private Guna.UI2.WinForms.Guna2Button btnClr;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblProId;
        private System.Windows.Forms.ComboBox comboBoxPid;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label lblPricers;
        private System.Windows.Forms.Label lblProductname;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.TextBox txtQty;
        private cafeshopmanagemantsystemDataSet1 cafeshopmanagemantsystemDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private cafeshopmanagemantsystemDataSet1TableAdapters.productTableAdapter productTableAdapter;
        public Guna.UI2.WinForms.Guna2DataGridView dgvDataProduct;
        private cafeshopmanagemantsystemDataSet4 cafeshopmanagemantsystemDataSet4;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private cafeshopmanagemantsystemDataSet4TableAdapters.productTableAdapter productTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        public Guna.UI2.WinForms.Guna2DataGridView dgvOrRecipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}