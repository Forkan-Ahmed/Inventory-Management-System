
namespace inventory
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            this.CategoryName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CategoryId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.homeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryGV = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryName
            // 
            this.CategoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CategoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CategoryName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CategoryName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CategoryName.HintForeColor = System.Drawing.Color.Empty;
            this.CategoryName.HintText = "";
            this.CategoryName.isPassword = false;
            this.CategoryName.LineFocusedColor = System.Drawing.Color.Blue;
            this.CategoryName.LineIdleColor = System.Drawing.Color.Maroon;
            this.CategoryName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CategoryName.LineThickness = 3;
            this.CategoryName.Location = new System.Drawing.Point(50, 210);
            this.CategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryName.MaxLength = 32767;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(158, 33);
            this.CategoryName.TabIndex = 15;
            this.CategoryName.Text = "Catagory Name";
            this.CategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CategoryId
            // 
            this.CategoryId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CategoryId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CategoryId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CategoryId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CategoryId.HintForeColor = System.Drawing.Color.Empty;
            this.CategoryId.HintText = "";
            this.CategoryId.isPassword = false;
            this.CategoryId.LineFocusedColor = System.Drawing.Color.Blue;
            this.CategoryId.LineIdleColor = System.Drawing.Color.Maroon;
            this.CategoryId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CategoryId.LineThickness = 3;
            this.CategoryId.Location = new System.Drawing.Point(50, 138);
            this.CategoryId.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryId.MaxLength = 32767;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Size = new System.Drawing.Size(158, 33);
            this.CategoryId.TabIndex = 14;
            this.CategoryId.Text = "Catagory ID";
            this.CategoryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CategoryId.OnValueChanged += new System.EventHandler(this.CategoryId_OnValueChanged);
            this.CategoryId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CategoryId_KeyDown);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Maroon;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(113, 364);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 34);
            this.homeButton.TabIndex = 23;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.deleteButton.Location = new System.Drawing.Point(198, 315);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 34);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Maroon;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Transparent;
            this.editButton.Location = new System.Drawing.Point(113, 315);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 34);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Maroon;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Transparent;
            this.addButton.Location = new System.Drawing.Point(27, 315);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 34);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1, -2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label8.Size = new System.Drawing.Size(932, 89);
            this.label8.TabIndex = 59;
            this.label8.Text = "INVENTORY SYSTEM FOR A COMPUTER SHOP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(343, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 27);
            this.label9.TabIndex = 60;
            this.label9.Text = "Manage Categories";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(517, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "CATEGORIES LIST";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1, 491);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(932, 10);
            this.label4.TabIndex = 65;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CategoryGV
            // 
            this.CategoryGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CategoryGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoryGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGV.BackgroundColor = System.Drawing.Color.White;
            this.CategoryGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryGV.EnableHeadersVisualStyles = false;
            this.CategoryGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryGV.Location = new System.Drawing.Point(315, 128);
            this.CategoryGV.Name = "CategoryGV";
            this.CategoryGV.RowHeadersVisible = false;
            this.CategoryGV.RowTemplate.Height = 30;
            this.CategoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryGV.Size = new System.Drawing.Size(604, 354);
            this.CategoryGV.TabIndex = 66;
            this.CategoryGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CategoryGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoryGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoryGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoryGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoryGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoryGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.CategoryGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoryGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoryGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoryGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoryGV.ThemeStyle.HeaderStyle.Height = 24;
            this.CategoryGV.ThemeStyle.ReadOnly = false;
            this.CategoryGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.CategoryGV.ThemeStyle.RowsStyle.Height = 30;
            this.CategoryGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoryGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGV_CellContentClick);
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(931, 501);
            this.Controls.Add(this.CategoryGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.CategoryId);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCategories_FormClosing);
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox CategoryName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CategoryId;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDataGridView CategoryGV;
    }
}