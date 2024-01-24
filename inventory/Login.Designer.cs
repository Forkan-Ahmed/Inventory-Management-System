
namespace inventory
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.Clear = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.gunaCheckBox1);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PasswordTb);
            this.panel1.Controls.Add(this.UnameTb);
            this.panel1.Location = new System.Drawing.Point(103, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 310);
            this.panel1.TabIndex = 52;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 7;
            this.gunaButton1.Size = new System.Drawing.Size(249, 30);
            this.gunaButton1.TabIndex = 55;
            this.gunaButton1.Text = "Login";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 60);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Maroon;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCheckBox1.ForeColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Location = new System.Drawing.Point(97, 278);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(129, 20);
            this.gunaCheckBox1.TabIndex = 53;
            this.gunaCheckBox1.Text = "Show Password";
            this.gunaCheckBox1.CheckedChanged += new System.EventHandler(this.gunaCheckBox1_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Transparent;
            this.Clear.Location = new System.Drawing.Point(30, 279);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(44, 19);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(21, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordTb
            // 
            this.PasswordTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTb.BackColor = System.Drawing.Color.Black;
            this.PasswordTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordTb.ForeColor = System.Drawing.Color.White;
            this.PasswordTb.HintForeColor = System.Drawing.Color.Empty;
            this.PasswordTb.HintText = "";
            this.PasswordTb.isPassword = true;
            this.PasswordTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PasswordTb.LineIdleColor = System.Drawing.Color.White;
            this.PasswordTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PasswordTb.LineThickness = 3;
            this.PasswordTb.Location = new System.Drawing.Point(21, 172);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTb.MaxLength = 32767;
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(206, 39);
            this.PasswordTb.TabIndex = 2;
            this.PasswordTb.Text = "Password";
            this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTb.OnValueChanged += new System.EventHandler(this.PasswordTb_OnValueChanged);
            this.PasswordTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTb_KeyDown);
            // 
            // UnameTb
            // 
            this.UnameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UnameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UnameTb.BackColor = System.Drawing.Color.Black;
            this.UnameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UnameTb.ForeColor = System.Drawing.Color.White;
            this.UnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.UnameTb.HintText = "";
            this.UnameTb.isPassword = false;
            this.UnameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.UnameTb.LineIdleColor = System.Drawing.Color.White;
            this.UnameTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.UnameTb.LineThickness = 3;
            this.UnameTb.Location = new System.Drawing.Point(21, 116);
            this.UnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UnameTb.MaxLength = 32767;
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(206, 39);
            this.UnameTb.TabIndex = 1;
            this.UnameTb.Text = "User Name";
            this.UnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UnameTb.OnValueChanged += new System.EventHandler(this.UnameTb_OnValueChanged);
            this.UnameTb.Click += new System.EventHandler(this.UnameTb_Click);
            this.UnameTb.Enter += new System.EventHandler(this.UnameTb_Enter);
            this.UnameTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnameTb_KeyDown);
            this.UnameTb.Leave += new System.EventHandler(this.UnameTb_Leave);
            this.UnameTb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UnameTb_MouseClick);
            this.UnameTb.MouseEnter += new System.EventHandler(this.UnameTb_MouseEnter);
            this.UnameTb.SystemColorsChanged += new System.EventHandler(this.UnameTb_SystemColorsChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(2, -2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(467, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY SYSTEM FOR A COMPUTER SHOP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(442, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(469, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private System.Windows.Forms.Label Clear;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label1;
    }
}