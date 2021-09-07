
namespace ContactManager.UI
{
    partial class UCTopBarResults
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTopBarResults));
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmdNew = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdReset = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbFilter
            // 
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Location = new System.Drawing.Point(460, 27);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(125, 21);
            this.CmbFilter.TabIndex = 15;
            this.CmbFilter.Click += new System.EventHandler(this.CmbFilter_Click);
            // 
            // CmdSearch
            // 
            this.CmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmdSearch.FlatAppearance.BorderSize = 0;
            this.CmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmdSearch.Image = global::ContactManager.Properties.Resources.search_2903;
            this.CmdSearch.Location = new System.Drawing.Point(604, 0);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(81, 67);
            this.CmdSearch.TabIndex = 14;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(220, 27);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(197, 20);
            this.TxtSearch.TabIndex = 13;
            // 
            // CmdNew
            // 
            this.CmdNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdNew.FlatAppearance.BorderSize = 0;
            this.CmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmdNew.Image = global::ContactManager.Properties.Resources.plus_945;
            this.CmdNew.Location = new System.Drawing.Point(0, 0);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdNew.Size = new System.Drawing.Size(64, 67);
            this.CmdNew.TabIndex = 12;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdEdit.BackgroundImage")));
            this.CmdEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdEdit.FlatAppearance.BorderSize = 0;
            this.CmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmdEdit.Image = global::ContactManager.Properties.Resources.pencil_938__2_;
            this.CmdEdit.Location = new System.Drawing.Point(64, 0);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdEdit.Size = new System.Drawing.Size(64, 67);
            this.CmdEdit.TabIndex = 9;
            this.CmdEdit.Text = "Bearbeiten";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdReset
            // 
            this.CmdReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmdReset.FlatAppearance.BorderSize = 0;
            this.CmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmdReset.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdReset.Location = new System.Drawing.Point(685, 0);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(93, 67);
            this.CmdReset.TabIndex = 11;
            this.CmdReset.Text = "Suche zurücksetzen";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdDelete.BackgroundImage")));
            this.CmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdDelete.FlatAppearance.BorderSize = 0;
            this.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmdDelete.Image = global::ContactManager.Properties.Resources.close_877;
            this.CmdDelete.Location = new System.Drawing.Point(129, 0);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdDelete.Size = new System.Drawing.Size(64, 67);
            this.CmdDelete.TabIndex = 10;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // UCTopBarResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.CmdDelete);
            this.Name = "UCTopBarResults";
            this.Size = new System.Drawing.Size(778, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdReset;
        private System.Windows.Forms.Button CmdDelete;
    }
}
