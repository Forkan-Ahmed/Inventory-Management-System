
namespace inventory
{
    partial class ManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            this.CustomerPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerGV = new Guna.UI.WinForms.GunaDataGridView();
            this.homeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerPhone.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CustomerPhone.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerPhone.HintText = "";
            this.CustomerPhone.isPassword = false;
            this.CustomerPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerPhone.LineIdleColor = System.Drawing.Color.Maroon;
            this.CustomerPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerPhone.LineThickness = 3;
            this.CustomerPhone.Location = new System.Drawing.Point(44, 258);
            this.CustomerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerPhone.MaxLength = 32767;
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Size = new System.Drawing.Size(191, 33);
            this.CustomerPhone.TabIndex = 14;
            this.CustomerPhone.Text = "Customer Phone";
            this.CustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CustomerName.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerName.HintText = "";
            this.CustomerName.isPassword = false;
            this.CustomerName.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerName.LineIdleColor = System.Drawing.Color.Maroon;
            this.CustomerName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerName.LineThickness = 3;
            this.CustomerName.Location = new System.Drawing.Point(44, 202);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerName.MaxLength = 32767;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(191, 33);
            this.CustomerName.TabIndex = 13;
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerName_KeyDown);
            // 
            // CustomerId
            // 
            this.CustomerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CustomerId.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerId.HintText = "";
            this.CustomerId.isPassword = false;
            this.CustomerId.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerId.LineIdleColor = System.Drawing.Color.Maroon;
            this.CustomerId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerId.LineThickness = 3;
            this.CustomerId.Location = new System.Drawing.Point(44, 137);
            this.CustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerId.MaxLength = 32767;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(191, 33);
            this.CustomerId.TabIndex = 12;
            this.CustomerId.Text = "Customer ID";
            this.CustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerId.OnValueChanged += new System.EventHandler(this.CustomerId_OnValueChanged);
            this.CustomerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerId_KeyDown);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerGV.EnableHeadersVisualStyles = false;
            this.CustomerGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.Location = new System.Drawing.Point(306, 137);
            this.CustomerGV.Name = "CustomerGV";
            this.CustomerGV.RowHeadersVisible = false;
            this.CustomerGV.RowTemplate.Height = 30;
            this.CustomerGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGV.Size = new System.Drawing.Size(604, 354);
            this.CustomerGV.TabIndex = 15;
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
            this.CustomerGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerGV.ThemeStyle.HeaderStyle.Height = 24;
            this.CustomerGV.ThemeStyle.ReadOnly = false;
            this.CustomerGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGV.ThemeStyle.RowsStyle.Height = 30;
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGV_CellContentClick);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Maroon;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(105, 406);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 34);
            this.homeButton.TabIndex = 19;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.deleteButton.Location = new System.Drawing.Point(190, 361);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 34);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Maroon;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Transparent;
            this.editButton.Location = new System.Drawing.Point(105, 361);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 34);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Maroon;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Transparent;
            this.addButton.Location = new System.Drawing.Point(21, 361);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 34);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.OrderLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(306, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 82);
            this.panel1.TabIndex = 20;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.OrderLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.ForeColor = System.Drawing.Color.Transparent;
            this.OrderLabel.Location = new System.Drawing.Point(35, 29);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(71, 23);
            this.OrderLabel.TabIndex = 21;
            this.OrderLabel.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order Count";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.AmountLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(523, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 82);
            this.panel2.TabIndex = 21;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.AmountLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.ForeColor = System.Drawing.Color.Transparent;
            this.AmountLabel.Location = new System.Drawing.Point(41, 29);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(82, 23);
            this.AmountLabel.TabIndex = 21;
            this.AmountLabel.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Order Amount";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.DateLabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(741, 504);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 82);
            this.panel3.TabIndex = 22;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.Transparent;
            this.DateLabel.Location = new System.Drawing.Point(55, 29);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(54, 23);
            this.DateLabel.TabIndex = 21;
            this.DateLabel.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Last Order Date";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(-2, -1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label8.Size = new System.Drawing.Size(932, 89);
            this.label8.TabIndex = 60;
            this.label8.Text = "INVENTORY SYSTEM FOR A COMPUTER SHOP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(355, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 27);
            this.label9.TabIndex = 61;
            this.label9.Text = "Manage Customers";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(550, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "CUSTOMERS LIST";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(-2, 592);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(932, 12);
            this.label4.TabIndex = 63;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(931, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.CustomerGV);
            this.Controls.Add(this.CustomerPhone);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCustomers_FormClosing);
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerId;
        private Guna.UI.WinForms.GunaDataGridView CustomerGV;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}