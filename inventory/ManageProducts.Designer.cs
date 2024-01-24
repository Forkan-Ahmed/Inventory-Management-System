
namespace inventory
{
    partial class ss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ss));
            this.ProductPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.homeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.ProductQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductDesc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatagoryCombo = new System.Windows.Forms.ComboBox();
            this.ProductGV = new Guna.UI.WinForms.GunaDataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ProductPrice.HintForeColor = System.Drawing.Color.Empty;
            this.ProductPrice.HintText = "";
            this.ProductPrice.isPassword = false;
            this.ProductPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductPrice.LineIdleColor = System.Drawing.Color.Maroon;
            this.ProductPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductPrice.LineThickness = 3;
            this.ProductPrice.Location = new System.Drawing.Point(29, 259);
            this.ProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ProductPrice.MaxLength = 32767;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(158, 33);
            this.ProductPrice.TabIndex = 33;
            this.ProductPrice.Text = "Product Price";
            this.ProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductPrice_KeyDown);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Maroon;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(93, 449);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 38);
            this.homeButton.TabIndex = 32;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.deleteButton.Location = new System.Drawing.Point(174, 409);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 38);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Maroon;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Transparent;
            this.editButton.Location = new System.Drawing.Point(93, 409);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 38);
            this.editButton.TabIndex = 31;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Maroon;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Transparent;
            this.addButton.Location = new System.Drawing.Point(12, 409);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 38);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductQuantity.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductQuantity.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ProductQuantity.HintForeColor = System.Drawing.Color.Empty;
            this.ProductQuantity.HintText = "";
            this.ProductQuantity.isPassword = false;
            this.ProductQuantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductQuantity.LineIdleColor = System.Drawing.Color.Maroon;
            this.ProductQuantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductQuantity.LineThickness = 3;
            this.ProductQuantity.Location = new System.Drawing.Point(29, 213);
            this.ProductQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.ProductQuantity.MaxLength = 32767;
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(158, 33);
            this.ProductQuantity.TabIndex = 28;
            this.ProductQuantity.Text = "Product Quantity";
            this.ProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductQuantity_KeyDown);
            // 
            // ProductName
            // 
            this.ProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ProductName.HintForeColor = System.Drawing.Color.Empty;
            this.ProductName.HintText = "";
            this.ProductName.isPassword = false;
            this.ProductName.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductName.LineIdleColor = System.Drawing.Color.Maroon;
            this.ProductName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductName.LineThickness = 3;
            this.ProductName.Location = new System.Drawing.Point(29, 164);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.ProductName.MaxLength = 32767;
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(158, 33);
            this.ProductName.TabIndex = 27;
            this.ProductName.Text = "Product Name";
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductName_KeyDown);
            // 
            // ProductId
            // 
            this.ProductId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ProductId.HintForeColor = System.Drawing.Color.Empty;
            this.ProductId.HintText = "";
            this.ProductId.isPassword = false;
            this.ProductId.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductId.LineIdleColor = System.Drawing.Color.Maroon;
            this.ProductId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductId.LineThickness = 3;
            this.ProductId.Location = new System.Drawing.Point(29, 117);
            this.ProductId.Margin = new System.Windows.Forms.Padding(4);
            this.ProductId.MaxLength = 32767;
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(158, 33);
            this.ProductId.TabIndex = 26;
            this.ProductId.Text = "Product Id";
            this.ProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductId_KeyDown);
            this.ProductId.Leave += new System.EventHandler(this.ProductId_Leave);
            // 
            // ProductDesc
            // 
            this.ProductDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductDesc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProductDesc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ProductDesc.HintForeColor = System.Drawing.Color.Empty;
            this.ProductDesc.HintText = "";
            this.ProductDesc.isPassword = false;
            this.ProductDesc.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductDesc.LineIdleColor = System.Drawing.Color.Maroon;
            this.ProductDesc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductDesc.LineThickness = 3;
            this.ProductDesc.Location = new System.Drawing.Point(29, 304);
            this.ProductDesc.Margin = new System.Windows.Forms.Padding(4);
            this.ProductDesc.MaxLength = 32767;
            this.ProductDesc.Name = "ProductDesc";
            this.ProductDesc.Size = new System.Drawing.Size(158, 33);
            this.ProductDesc.TabIndex = 33;
            this.ProductDesc.Text = "Description";
            this.ProductDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductDesc_KeyDown);
            // 
            // CatagoryCombo
            // 
            this.CatagoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatagoryCombo.ForeColor = System.Drawing.Color.Brown;
            this.CatagoryCombo.FormattingEnabled = true;
            this.CatagoryCombo.Location = new System.Drawing.Point(29, 359);
            this.CatagoryCombo.Name = "CatagoryCombo";
            this.CatagoryCombo.Size = new System.Drawing.Size(158, 24);
            this.CatagoryCombo.TabIndex = 34;
            this.CatagoryCombo.Text = "Product Catagory";
            this.CatagoryCombo.SelectedIndexChanged += new System.EventHandler(this.CatagoryCombo_SelectedIndexChanged);
            this.CatagoryCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatagoryCombo_KeyDown);
            // 
            // ProductGV
            // 
            this.ProductGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductGV.EnableHeadersVisualStyles = false;
            this.ProductGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGV.Location = new System.Drawing.Point(264, 151);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersVisible = false;
            this.ProductGV.RowTemplate.Height = 30;
            this.ProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGV.Size = new System.Drawing.Size(655, 322);
            this.ProductGV.TabIndex = 35;
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
            this.ProductGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductGV.ThemeStyle.HeaderStyle.Height = 24;
            this.ProductGV.ThemeStyle.ReadOnly = false;
            this.ProductGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGV.ThemeStyle.RowsStyle.Height = 30;
            this.ProductGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCombo.ForeColor = System.Drawing.Color.Brown;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(436, 117);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(173, 24);
            this.SearchCombo.TabIndex = 34;
            this.SearchCombo.Text = "Select Catagory";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.CatagoryCombo_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Maroon;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.Transparent;
            this.SearchButton.Location = new System.Drawing.Point(605, 115);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(96, 30);
            this.SearchButton.TabIndex = 36;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Maroon;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Location = new System.Drawing.Point(707, 115);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 30);
            this.RefreshButton.TabIndex = 37;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(0, -2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label8.Size = new System.Drawing.Size(932, 89);
            this.label8.TabIndex = 61;
            this.label8.Text = "INVENTORY SYSTEM FOR A COMPUTER SHOP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(341, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 27);
            this.label9.TabIndex = 62;
            this.label9.Text = "Manage Products";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(528, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 65;
            this.label7.Text = "PRODUCTS LIST";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 490);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(932, 10);
            this.label2.TabIndex = 66;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(931, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.CatagoryCombo);
            this.Controls.Add(this.ProductDesc);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ProductQuantity);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ss_FormClosing);
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductPrice;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductDesc;
        private System.Windows.Forms.ComboBox CatagoryCombo;
        private Guna.UI.WinForms.GunaDataGridView ProductGV;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}