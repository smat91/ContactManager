
namespace ContactManager
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
            System.Windows.Forms.Button CmdLogin;
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblLoginText = new System.Windows.Forms.Label();
            this.LblExitLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            CmdLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdLogin
            // 
            CmdLogin.BackColor = System.Drawing.Color.SteelBlue;
            CmdLogin.FlatAppearance.BorderSize = 0;
            CmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CmdLogin.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F);
            CmdLogin.ForeColor = System.Drawing.Color.White;
            CmdLogin.Location = new System.Drawing.Point(39, 208);
            CmdLogin.Name = "CmdLogin";
            CmdLogin.Size = new System.Drawing.Size(153, 32);
            CmdLogin.TabIndex = 4;
            CmdLogin.Text = "Login";
            CmdLogin.UseVisualStyleBackColor = false;
            CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // LblUser
            // 
            this.LblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.LblUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblUser.Location = new System.Drawing.Point(39, 120);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(86, 15);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Benutzername:";
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.LblPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPassword.Location = new System.Drawing.Point(39, 166);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(57, 15);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Passwort:";
            // 
            // TxtUser
            // 
            this.TxtUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtUser.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.TxtUser.Location = new System.Drawing.Point(39, 136);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(153, 23);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI Historic", 7F);
            this.TxtPassword.Location = new System.Drawing.Point(39, 182);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(153, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // LblLoginText
            // 
            this.LblLoginText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblLoginText.AutoSize = true;
            this.LblLoginText.Font = new System.Drawing.Font("Segoe UI Historic", 13F);
            this.LblLoginText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblLoginText.Location = new System.Drawing.Point(38, 80);
            this.LblLoginText.Name = "LblLoginText";
            this.LblLoginText.Size = new System.Drawing.Size(158, 25);
            this.LblLoginText.TabIndex = 5;
            this.LblLoginText.Text = "Melden Sie sich an";
            // 
            // LblExitLogin
            // 
            this.LblExitLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblExitLogin.AutoSize = true;
            this.LblExitLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblExitLogin.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Underline);
            this.LblExitLogin.ForeColor = System.Drawing.Color.White;
            this.LblExitLogin.Location = new System.Drawing.Point(100, 289);
            this.LblExitLogin.Name = "LblExitLogin";
            this.LblExitLogin.Size = new System.Drawing.Size(25, 15);
            this.LblExitLogin.TabIndex = 6;
            this.LblExitLogin.Text = "Exit";
            this.LblExitLogin.Click += new System.EventHandler(this.LblExitLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactManager.Properties.Resources.sign_in_3301__1_;
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 65);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(226, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblExitLogin);
            this.Controls.Add(this.LblLoginText);
            this.Controls.Add(CmdLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblLoginText;
        private System.Windows.Forms.Label LblExitLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}