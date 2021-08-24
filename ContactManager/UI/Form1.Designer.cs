
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
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmdNew = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.CmdHome = new System.Windows.Forms.Button();
            this.CmdKunde = new System.Windows.Forms.Button();
            this.CmdMitarbeiter = new System.Windows.Forms.Button();
            this.CmdLernende = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(100, 11);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(75, 46);
            this.CmdEdit.TabIndex = 2;
            this.CmdEdit.Text = "Bearbeiten";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(181, 11);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 45);
            this.CmdDelete.TabIndex = 3;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(788, 16);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(108, 45);
            this.CmdReset.TabIndex = 4;
            this.CmdReset.Text = "Suche zurücksetzen";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CmbFilter);
            this.panel2.Controls.Add(this.CmdSearch);
            this.panel2.Controls.Add(this.TxtSearch);
            this.panel2.Controls.Add(this.CmdNew);
            this.panel2.Controls.Add(this.CmdEdit);
            this.panel2.Controls.Add(this.CmdReset);
            this.panel2.Controls.Add(this.CmdDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(164, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 77);
            this.panel2.TabIndex = 6;
            // 
            // CmbFilter
            // 
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Location = new System.Drawing.Point(537, 31);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(145, 23);
            this.CmbFilter.TabIndex = 8;
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(688, 16);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(94, 45);
            this.CmdSearch.TabIndex = 7;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(292, 31);
            this.TxtSearch.Multiline = true;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(229, 23);
            this.TxtSearch.TabIndex = 6;
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(19, 11);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(75, 45);
            this.CmdNew.TabIndex = 5;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
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
            this.CmdHome.BackColor = System.Drawing.Color.White;
            this.CmdHome.Location = new System.Drawing.Point(0, 0);
            this.CmdHome.Margin = new System.Windows.Forms.Padding(0);
            this.CmdHome.Name = "CmdHome";
            this.CmdHome.Size = new System.Drawing.Size(164, 77);
            this.CmdHome.TabIndex = 0;
            this.CmdHome.Text = "Home";
            this.CmdHome.UseVisualStyleBackColor = false;
            this.CmdHome.Click += new System.EventHandler(this.CmdHome_Click);
            // 
            // CmdKunde
            // 
            this.CmdKunde.BackColor = System.Drawing.Color.White;
            this.CmdKunde.Location = new System.Drawing.Point(0, 113);
            this.CmdKunde.Margin = new System.Windows.Forms.Padding(0);
            this.CmdKunde.Name = "CmdKunde";
            this.CmdKunde.Size = new System.Drawing.Size(164, 35);
            this.CmdKunde.TabIndex = 1;
            this.CmdKunde.Text = "Kunde";
            this.CmdKunde.UseVisualStyleBackColor = false;
            this.CmdKunde.Click += new System.EventHandler(this.CmdKunde_Click);
            // 
            // CmdMitarbeiter
            // 
            this.CmdMitarbeiter.BackColor = System.Drawing.Color.White;
            this.CmdMitarbeiter.Location = new System.Drawing.Point(0, 148);
            this.CmdMitarbeiter.Margin = new System.Windows.Forms.Padding(0);
            this.CmdMitarbeiter.Name = "CmdMitarbeiter";
            this.CmdMitarbeiter.Size = new System.Drawing.Size(164, 35);
            this.CmdMitarbeiter.TabIndex = 2;
            this.CmdMitarbeiter.Text = "Mitarbeiter";
            this.CmdMitarbeiter.UseVisualStyleBackColor = false;
            this.CmdMitarbeiter.Click += new System.EventHandler(this.CmdMitarbeiter_Click);
            // 
            // CmdLernende
            // 
            this.CmdLernende.BackColor = System.Drawing.Color.White;
            this.CmdLernende.Location = new System.Drawing.Point(0, 183);
            this.CmdLernende.Margin = new System.Windows.Forms.Padding(0);
            this.CmdLernende.Name = "CmdLernende";
            this.CmdLernende.Size = new System.Drawing.Size(164, 35);
            this.CmdLernende.TabIndex = 3;
            this.CmdLernende.Text = "Lernende";
            this.CmdLernende.UseVisualStyleBackColor = false;
            this.CmdLernende.Click += new System.EventHandler(this.CmdLernende_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CmdLernende);
            this.panel1.Controls.Add(this.CmdMitarbeiter);
            this.panel1.Controls.Add(this.CmdKunde);
            this.panel1.Controls.Add(this.CmdHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 595);
            this.panel1.TabIndex = 5;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(164, 77);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(908, 518);
            this.PanelContainer.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 595);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button CmdHome;
        private System.Windows.Forms.Button CmdKunde;
        private System.Windows.Forms.Button CmdMitarbeiter;
        private System.Windows.Forms.Button CmdLernende;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

