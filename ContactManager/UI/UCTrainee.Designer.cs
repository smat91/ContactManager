
namespace ContactManager.UI
{
    partial class UCTrainee
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvTrainee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTrainee)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTrainee
            // 
            this.DgvTrainee.AllowUserToAddRows = false;
            this.DgvTrainee.AllowUserToDeleteRows = false;
            this.DgvTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTrainee.Location = new System.Drawing.Point(0, 0);
            this.DgvTrainee.MultiSelect = false;
            this.DgvTrainee.Name = "DgvTrainee";
            this.DgvTrainee.ReadOnly = true;
            this.DgvTrainee.RowTemplate.Height = 25;
            this.DgvTrainee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTrainee.Size = new System.Drawing.Size(908, 518);
            this.DgvTrainee.TabIndex = 3;
            // 
            // UCTrainee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvTrainee);
            this.Name = "UCTrainee";
            this.Size = new System.Drawing.Size(1088, 634);
            this.Load += new System.EventHandler(this.UCTrainee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTrainee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTrainee;
    }
}
