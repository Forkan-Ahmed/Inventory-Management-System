
namespace inventory
{
    partial class ManageOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            this.CustomerGV = new Guna.UI.WinForms.GunaDataGridView();
            this.CustomerId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OrderId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductGV = new Guna.UI.WinForms.GunaDataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderGV = new Guna.UI.WinForms.GunaDataGridView();
            this.Qty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addButton = new System.Windows.Forms.Button();
            this.showAmount = new System.Windows.Forms.Label();
            this.totalAmnt = new System.Windows.Forms.Label();
            this.InsertOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.orderDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGV
            // 
            this.CustomerGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGV.BackgroundColor = System.Drawing.Color.White;
            this.CustomerGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerGV.EnableHeadersVisualStyles = false;
            this.CustomerGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.Location = new System.Drawing.Point(6, 120);
            this.CustomerGV.Name = "CustomerGV";
            this.CustomerGV.RowHeadersVisible = false;
            this.CustomerGV.RowTemplate.Height = 30;
            this.CustomerGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGV.Size = new System.Drawing.Size(377, 190);
            this.CustomerGV.TabIndex = 36;
            this.CustomerGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.CustomerGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerGV.ThemeStyle.HeaderStyle.Height = 24;
            this.CustomerGV.ThemeStyle.ReadOnly = false;
            this.CustomerGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGV.ThemeStyle.RowsStyle.Height = 30;
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGV_CellContentClick_1);
            // 
            // CustomerId
            // 
            this.CustomerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerId.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerId.HintText = "";
            this.CustomerId.isPassword = false;
            this.CustomerId.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerId.LineIdleColor = System.Drawing.Color.Maroon;
            this.CustomerId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerId.LineThickness = 3;
            this.CustomerId.Location = new System.Drawing.Point(90, 358);
            this.CustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerId.MaxLength = 32767;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(157, 33);
            this.CustomerId.TabIndex = 39;
            this.CustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerId_KeyDown);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerName.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerName.HintText = "";
            this.CustomerName.isPassword = false;
            this.CustomerName.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerName.LineIdleColor = System.Drawing.Color.Maroon;
            this.CustomerName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerName.LineThickness = 3;
            this.CustomerName.Location = new System.Drawing.Point(90, 399);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerName.MaxLength = 32767;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(157, 33);
            this.CustomerName.TabIndex = 38;
            this.CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OrderId
            // 
            this.OrderId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.OrderId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.OrderId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.OrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderId.HintForeColor = System.Drawing.Color.Empty;
            this.OrderId.HintText = "";
            this.OrderId.isPassword = false;
            this.OrderId.LineFocusedColor = System.Drawing.Color.Blue;
            this.OrderId.LineIdleColor = System.Drawing.Color.Maroon;
            this.OrderId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.OrderId.LineThickness = 3;
            this.OrderId.Location = new System.Drawing.Point(88, 317);
            this.OrderId.Margin = new System.Windows.Forms.Padding(4);
            this.OrderId.MaxLength = 32767;
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(159, 33);
            this.OrderId.TabIndex = 37;
            this.OrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OrderId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderId_KeyDown);
            // 
            // ProductGV
            // 
            this.ProductGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProductGV.EnableHeadersVisualStyles = false;
            this.ProductGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGV.Location = new System.Drawing.Point(394, 120);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersVisible = false;
            this.ProductGV.RowTemplate.Height = 30;
            this.ProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGV.Size = new System.Drawing.Size(525, 190);
            this.ProductGV.TabIndex = 41;
            this.ProductGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.ProductGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductGV.ThemeStyle.HeaderStyle.Height = 24;
            this.ProductGV.ThemeStyle.ReadOnly = false;
            this.ProductGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGV.ThemeStyle.RowsStyle.Height = 30;
            this.ProductGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // SearchCombo
            // 
            this.SearchCombo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCombo.ForeColor = System.Drawing.Color.Brown;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(578, 93);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(173, 24);
            this.SearchCombo.TabIndex = 40;
            this.SearchCombo.Text = "Select Catagory";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            this.SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo_SelectionChangeCommitted_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(521, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(62, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Order Date";
            // 
            // OrderGV
            // 
            this.OrderGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.OrderGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrderGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrderGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrderGV.EnableHeadersVisualStyles = false;
            this.OrderGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGV.Location = new System.Drawing.Point(254, 349);
            this.OrderGV.Name = "OrderGV";
            this.OrderGV.RowHeadersVisible = false;
            this.OrderGV.RowTemplate.Height = 30;
            this.OrderGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGV.Size = new System.Drawing.Size(654, 209);
            this.OrderGV.TabIndex = 45;
            this.OrderGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.OrderGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.OrderGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderGV.ThemeStyle.HeaderStyle.Height = 24;
            this.OrderGV.ThemeStyle.ReadOnly = false;
            this.OrderGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderGV.ThemeStyle.RowsStyle.Height = 30;
            this.OrderGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Qty
            // 
            this.Qty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Qty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Qty.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Qty.HintForeColor = System.Drawing.Color.Empty;
            this.Qty.HintText = "";
            this.Qty.isPassword = false;
            this.Qty.LineFocusedColor = System.Drawing.Color.Blue;
            this.Qty.LineIdleColor = System.Drawing.Color.Maroon;
            this.Qty.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Qty.LineThickness = 3;
            this.Qty.Location = new System.Drawing.Point(592, 309);
            this.Qty.Margin = new System.Windows.Forms.Padding(4);
            this.Qty.MaxLength = 32767;
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(138, 33);
            this.Qty.TabIndex = 46;
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Maroon;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(727, 316);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 30);
            this.addButton.TabIndex = 47;
            this.addButton.Text = "Add To Cart";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showAmount
            // 
            this.showAmount.BackColor = System.Drawing.Color.Maroon;
            this.showAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAmount.ForeColor = System.Drawing.Color.White;
            this.showAmount.Location = new System.Drawing.Point(366, 564);
            this.showAmount.Name = "showAmount";
            this.showAmount.Size = new System.Drawing.Size(131, 32);
            this.showAmount.TabIndex = 48;
            this.showAmount.Text = "  Total Amount (TK)";
            this.showAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showAmount.Click += new System.EventHandler(this.showAmount_Click);
            // 
            // totalAmnt
            // 
            this.totalAmnt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmnt.ForeColor = System.Drawing.Color.DarkGreen;
            this.totalAmnt.Location = new System.Drawing.Point(503, 566);
            this.totalAmnt.Name = "totalAmnt";
            this.totalAmnt.Size = new System.Drawing.Size(187, 32);
            this.totalAmnt.TabIndex = 49;
            this.totalAmnt.Click += new System.EventHandler(this.totalAmnt_Click);
            // 
            // InsertOrder
            // 
            this.InsertOrder.BackColor = System.Drawing.Color.Maroon;
            this.InsertOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertOrder.ForeColor = System.Drawing.Color.White;
            this.InsertOrder.Location = new System.Drawing.Point(16, 525);
            this.InsertOrder.Name = "InsertOrder";
            this.InsertOrder.Size = new System.Drawing.Size(113, 33);
            this.InsertOrder.TabIndex = 51;
            this.InsertOrder.Text = "Insert Order";
            this.InsertOrder.UseVisualStyleBackColor = false;
            this.InsertOrder.Click += new System.EventHandler(this.InsertOrder_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(133, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 33);
            this.button2.TabIndex = 51;
            this.button2.Text = "View Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orderDate
            // 
            this.orderDate.BaseColor = System.Drawing.Color.White;
            this.orderDate.BorderColor = System.Drawing.Color.Silver;
            this.orderDate.CustomFormat = null;
            this.orderDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.orderDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderDate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.ForeColor = System.Drawing.Color.Black;
            this.orderDate.Location = new System.Drawing.Point(12, 474);
            this.orderDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.orderDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.orderDate.Name = "orderDate";
            this.orderDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.orderDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderDate.OnPressedColor = System.Drawing.Color.Black;
            this.orderDate.Size = new System.Drawing.Size(223, 30);
            this.orderDate.TabIndex = 52;
            this.orderDate.Text = "Tuesday, January 5, 2021";
            this.orderDate.Value = new System.DateTime(2021, 1, 5, 23, 15, 2, 383);
            this.orderDate.ValueChanged += new System.EventHandler(this.orderDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(9, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Order ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(13, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Cust .ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(3, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Cust.Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(129, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "CUSTOMERS LIST";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(88, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 57;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1, 1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label8.Size = new System.Drawing.Size(929, 89);
            this.label8.TabIndex = 58;
            this.label8.Text = "INVENTORY SYSTEM FOR A COMPUTER SHOP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(364, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 27);
            this.label9.TabIndex = 59;
            this.label9.Text = "Manage Orders";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Maroon;
            this.label10.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(0, 601);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label10.Size = new System.Drawing.Size(932, 10);
            this.label10.TabIndex = 65;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(931, 611);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InsertOrder);
            this.Controls.Add(this.totalAmnt);
            this.Controls.Add(this.showAmount);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.OrderGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.CustomerGV);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageOrders_FormClosing);
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView CustomerGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OrderId;
        private Guna.UI.WinForms.GunaDataGridView ProductGV;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView OrderGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Qty;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label showAmount;
        private System.Windows.Forms.Label totalAmnt;
        private System.Windows.Forms.Button InsertOrder;
        private System.Windows.Forms.Button button2;
        private Guna.UI.WinForms.GunaDateTimePicker orderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}