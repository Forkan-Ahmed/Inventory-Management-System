
namespace inventory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserFullName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.UserPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userGV = new Guna.UI.WinForms.GunaDataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.UserName.HintForeColor = System.Drawing.Color.Empty;
            this.UserName.HintText = "";
            this.UserName.isPassword = false;
            this.UserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.UserName.LineIdleColor = System.Drawing.Color.Maroon;
            this.UserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UserName.LineThickness = 3;
            this.UserName.Location = new System.Drawing.Point(32, 137);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.MaxLength = 32767;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(158, 33);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name";
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserName_KeyDown);
            // 
            // UserFullName
            // 
            this.UserFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserFullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserFullName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserFullName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.UserFullName.HintForeColor = System.Drawing.Color.Empty;
            this.UserFullName.HintText = "";
            this.UserFullName.isPassword = false;
            this.UserFullName.LineFocusedColor = System.Drawing.Color.Blue;
            this.UserFullName.LineIdleColor = System.Drawing.Color.Maroon;
            this.UserFullName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UserFullName.LineThickness = 3;
            this.UserFullName.Location = new System.Drawing.Point(32, 195);
            this.UserFullName.Margin = new System.Windows.Forms.Padding(4);
            this.UserFullName.MaxLength = 32767;
            this.UserFullName.Name = "UserFullName";
            this.UserFullName.Size = new System.Drawing.Size(158, 33);
            this.UserFullName.TabIndex = 1;
            this.UserFullName.Text = "User Full Name";
            this.UserFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserFullName_KeyDown);
            // 
            // UserPassword
            // 
            this.UserPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.UserPassword.HintForeColor = System.Drawing.Color.Empty;
            this.UserPassword.HintText = "";
            this.UserPassword.isPassword = false;
            this.UserPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.UserPassword.LineIdleColor = System.Drawing.Color.Maroon;
            this.UserPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UserPassword.LineThickness = 3;
            this.UserPassword.Location = new System.Drawing.Point(32, 251);
            this.UserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.UserPassword.MaxLength = 32767;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(158, 33);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.Text = "User Password";
            this.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserPassword_KeyDown);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Maroon;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Transparent;
            this.addButton.Location = new System.Drawing.Point(32, 383);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 34);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Maroon;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Transparent;
            this.editButton.Location = new System.Drawing.Point(120, 383);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 34);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Maroon;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(120, 423);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 34);
            this.homeButton.TabIndex = 7;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // UserPhone
            // 
            this.UserPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserPhone.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.UserPhone.HintForeColor = System.Drawing.Color.Empty;
            this.UserPhone.HintText = "";
            this.UserPhone.isPassword = false;
            this.UserPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.UserPhone.LineIdleColor = System.Drawing.Color.Maroon;
            this.UserPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UserPhone.LineThickness = 3;
            this.UserPhone.Location = new System.Drawing.Point(32, 310);
            this.UserPhone.Margin = new System.Windows.Forms.Padding(4);
            this.UserPhone.MaxLength = 32767;
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.Size = new System.Drawing.Size(158, 33);
            this.UserPhone.TabIndex = 8;
            this.UserPhone.Text = "Phone";
            this.UserPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // userGV
            // 
            this.userGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.userGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGV.BackgroundColor = System.Drawing.Color.White;
            this.userGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userGV.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.userGV.EnableHeadersVisualStyles = false;
            this.userGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGV.Location = new System.Drawing.Point(316, 137);
            this.userGV.Name = "userGV";
            this.userGV.RowHeadersVisible = false;
            this.userGV.RowTemplate.Height = 30;
            this.userGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGV.Size = new System.Drawing.Size(587, 339);
            this.userGV.TabIndex = 11;
            this.userGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.userGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.userGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userGV.ThemeStyle.HeaderStyle.Height = 24;
            this.userGV.ThemeStyle.ReadOnly = false;
            this.userGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userGV.ThemeStyle.RowsStyle.Height = 30;
            this.userGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGV_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.deleteButton.Location = new System.Drawing.Point(209, 383);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 34);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.label8.TabIndex = 60;
            this.label8.Text = "INVENTORY SYSTEM FOR A COMPUTER SHOP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(353, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 27);
            this.label9.TabIndex = 61;
            this.label9.Text = "Manage Users";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(549, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 62;
            this.label7.Text = "USERS LIST";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(0, 492);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(932, 10);
            this.label4.TabIndex = 64;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(931, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userGV);
            this.Controls.Add(this.UserPhone);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserFullName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox UserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserFullName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserPassword;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button homeButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserPhone;
        private Guna.UI.WinForms.GunaDataGridView userGV;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

