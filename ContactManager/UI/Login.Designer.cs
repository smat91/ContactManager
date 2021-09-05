
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
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblUser.AutoSize = true;
            this.LblUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblUser.Location = new System.Drawing.Point(12, 23);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(86, 15);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Benutzername:";
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPassword.AutoSize = true;
            this.LblPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPassword.Location = new System.Drawing.Point(12, 74);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(57, 15);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Passwort:";
            // 
            // TxtUser
            // 
            this.TxtUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtUser.Location = new System.Drawing.Point(107, 20);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(249, 23);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPassword.Location = new System.Drawing.Point(107, 71);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(249, 23);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // CmdLogin
            // 
            this.CmdLogin.Location = new System.Drawing.Point(12, 136);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(343, 40);
            this.CmdLogin.TabIndex = 4;
            this.CmdLogin.Text = "Login";
            this.CmdLogin.UseVisualStyleBackColor = true;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(368, 191);
            this.Controls.Add(this.CmdLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUser);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button CmdLogin;
    }
}