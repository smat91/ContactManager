
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
            this.CmdNew = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.CmdHome = new System.Windows.Forms.Button();
            this.CmdKunde = new System.Windows.Forms.Button();
            this.CmdMitarbeiter = new System.Windows.Forms.Button();
            this.CmdLernende = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(19, 12);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(75, 45);
            this.CmdNew.TabIndex = 1;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(100, 11);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(75, 46);
            this.CmdEdit.TabIndex = 2;
            this.CmdEdit.Text = "Bearbeiten";
            this.CmdEdit.UseVisualStyleBackColor = true;
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
            this.CmdReset.Location = new System.Drawing.Point(262, 12);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(108, 45);
            this.CmdReset.TabIndex = 4;
            this.CmdReset.Text = "Filter zurücksetzen";
            this.CmdReset.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
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
            this.PanelContainer.Controls.Add(this.TxtOutput);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(164, 77);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(908, 518);
            this.PanelContainer.TabIndex = 8;
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(19, 47);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOutput.Size = new System.Drawing.Size(870, 425);
            this.TxtOutput.TabIndex = 2;
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
            this.panel1.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdNew;
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
        private System.Windows.Forms.TextBox TxtOutput;
    }
}

