
namespace ContactManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.CmdHome = new System.Windows.Forms.Button();
            this.CmdKunde = new System.Windows.Forms.Button();
            this.CmdMitarbeiter = new System.Windows.Forms.Button();
            this.CmdLernende = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelContainerMain = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelContainerTop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 288);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 35);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 323);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 35);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // CmdHome
            // 
            this.CmdHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.CmdHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdHome.Location = new System.Drawing.Point(0, 0);
            this.CmdHome.Margin = new System.Windows.Forms.Padding(0);
            this.CmdHome.Name = "CmdHome";
            this.CmdHome.Size = new System.Drawing.Size(164, 77);
            this.CmdHome.TabIndex = 0;
            this.CmdHome.Text = "Dashboard";
            this.CmdHome.UseVisualStyleBackColor = false;
            this.CmdHome.Click += new System.EventHandler(this.CmdHome_Click);
            this.CmdHome.MouseEnter += new System.EventHandler(this.CmdHome_MouseEnter);
            this.CmdHome.MouseLeave += new System.EventHandler(this.CmdHome_MouseLeave);
            // 
            // CmdKunde
            // 
            this.CmdKunde.BackColor = System.Drawing.Color.Transparent;
            this.CmdKunde.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdKunde.FlatAppearance.BorderSize = 0;
            this.CmdKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdKunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdKunde.ForeColor = System.Drawing.Color.Gainsboro;
            this.CmdKunde.Image = ((System.Drawing.Image)(resources.GetObject("CmdKunde.Image")));
            this.CmdKunde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdKunde.Location = new System.Drawing.Point(0, 77);
            this.CmdKunde.Margin = new System.Windows.Forms.Padding(0);
            this.CmdKunde.Name = "CmdKunde";
            this.CmdKunde.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CmdKunde.Size = new System.Drawing.Size(164, 50);
            this.CmdKunde.TabIndex = 1;
            this.CmdKunde.Text = "  Kunde";
            this.CmdKunde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdKunde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdKunde.UseVisualStyleBackColor = false;
            this.CmdKunde.Click += new System.EventHandler(this.CmdKunde_Click);
            this.CmdKunde.MouseEnter += new System.EventHandler(this.CmdKunde_MouseEnter);
            this.CmdKunde.MouseLeave += new System.EventHandler(this.CmdKunde_MouseLeave);
            // 
            // CmdMitarbeiter
            // 
            this.CmdMitarbeiter.BackColor = System.Drawing.Color.Transparent;
            this.CmdMitarbeiter.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdMitarbeiter.FlatAppearance.BorderSize = 0;
            this.CmdMitarbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdMitarbeiter.ForeColor = System.Drawing.Color.Gainsboro;
            this.CmdMitarbeiter.Image = ((System.Drawing.Image)(resources.GetObject("CmdMitarbeiter.Image")));
            this.CmdMitarbeiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdMitarbeiter.Location = new System.Drawing.Point(0, 127);
            this.CmdMitarbeiter.Margin = new System.Windows.Forms.Padding(0);
            this.CmdMitarbeiter.Name = "CmdMitarbeiter";
            this.CmdMitarbeiter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CmdMitarbeiter.Size = new System.Drawing.Size(164, 50);
            this.CmdMitarbeiter.TabIndex = 2;
            this.CmdMitarbeiter.Text = "  Mitarbeitende";
            this.CmdMitarbeiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdMitarbeiter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdMitarbeiter.UseVisualStyleBackColor = false;
            this.CmdMitarbeiter.Click += new System.EventHandler(this.CmdMitarbeiter_Click);
            this.CmdMitarbeiter.MouseEnter += new System.EventHandler(this.CmdMitarbeiter_MouseEnter);
            this.CmdMitarbeiter.MouseLeave += new System.EventHandler(this.CmdMitarbeiter_MouseLeave);
            // 
            // CmdLernende
            // 
            this.CmdLernende.BackColor = System.Drawing.Color.Transparent;
            this.CmdLernende.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdLernende.FlatAppearance.BorderSize = 0;
            this.CmdLernende.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLernende.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdLernende.ForeColor = System.Drawing.Color.Gainsboro;
            this.CmdLernende.Image = ((System.Drawing.Image)(resources.GetObject("CmdLernende.Image")));
            this.CmdLernende.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdLernende.Location = new System.Drawing.Point(0, 177);
            this.CmdLernende.Margin = new System.Windows.Forms.Padding(0);
            this.CmdLernende.Name = "CmdLernende";
            this.CmdLernende.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CmdLernende.Size = new System.Drawing.Size(164, 50);
            this.CmdLernende.TabIndex = 3;
            this.CmdLernende.Text = "  Lernende";
            this.CmdLernende.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdLernende.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdLernende.UseVisualStyleBackColor = false;
            this.CmdLernende.Click += new System.EventHandler(this.CmdLernende_Click);
            this.CmdLernende.MouseEnter += new System.EventHandler(this.CmdLernende_MouseEnter);
            this.CmdLernende.MouseLeave += new System.EventHandler(this.CmdLernende_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.CmdLernende);
            this.panel1.Controls.Add(this.CmdMitarbeiter);
            this.panel1.Controls.Add(this.CmdKunde);
            this.panel1.Controls.Add(this.CmdHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 595);
            this.panel1.TabIndex = 5;
            // 
            // PanelContainerMain
            // 
            this.PanelContainerMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContainerMain.Location = new System.Drawing.Point(164, 77);
            this.PanelContainerMain.Name = "PanelContainerMain";
            this.PanelContainerMain.Size = new System.Drawing.Size(908, 518);
            this.PanelContainerMain.TabIndex = 8;
            // 
            // PanelContainerTop
            // 
            this.PanelContainerTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContainerTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PanelContainerTop.Location = new System.Drawing.Point(164, 0);
            this.PanelContainerTop.Name = "PanelContainerTop";
            this.PanelContainerTop.Size = new System.Drawing.Size(908, 77);
            this.PanelContainerTop.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1072, 595);
            this.Controls.Add(this.PanelContainerTop);
            this.Controls.Add(this.PanelContainerMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button CmdHome;
        private System.Windows.Forms.Button CmdKunde;
        private System.Windows.Forms.Button CmdMitarbeiter;
        private System.Windows.Forms.Button CmdLernende;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContainerMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel PanelContainerTop;
    }
}

