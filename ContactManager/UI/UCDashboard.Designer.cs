
namespace ContactManager.UI
{
    partial class UCDashboard
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
            this.LblNumberOfCustomers = new System.Windows.Forms.Label();
            this.LblNumberOfEmployees = new System.Windows.Forms.Label();
            this.LblNumberOfTrainees = new System.Windows.Forms.Label();
            this.DvgMutationLogs = new System.Windows.Forms.DataGridView();
            this.mutationLogs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DvgMutationLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNumberOfCustomers
            // 
            this.LblNumberOfCustomers.AutoSize = true;
            this.LblNumberOfCustomers.Location = new System.Drawing.Point(29, 31);
            this.LblNumberOfCustomers.Name = "LblNumberOfCustomers";
            this.LblNumberOfCustomers.Size = new System.Drawing.Size(38, 15);
            this.LblNumberOfCustomers.TabIndex = 0;
            this.LblNumberOfCustomers.Text = "label1";
            // 
            // LblNumberOfEmployees
            // 
            this.LblNumberOfEmployees.AutoSize = true;
            this.LblNumberOfEmployees.Location = new System.Drawing.Point(29, 67);
            this.LblNumberOfEmployees.Name = "LblNumberOfEmployees";
            this.LblNumberOfEmployees.Size = new System.Drawing.Size(38, 15);
            this.LblNumberOfEmployees.TabIndex = 1;
            this.LblNumberOfEmployees.Text = "label2";
            // 
            // LblNumberOfTrainees
            // 
            this.LblNumberOfTrainees.AutoSize = true;
            this.LblNumberOfTrainees.Location = new System.Drawing.Point(29, 105);
            this.LblNumberOfTrainees.Name = "LblNumberOfTrainees";
            this.LblNumberOfTrainees.Size = new System.Drawing.Size(38, 15);
            this.LblNumberOfTrainees.TabIndex = 2;
            this.LblNumberOfTrainees.Text = "label3";
            // 
            // DvgMutationLogs
            // 
            this.DvgMutationLogs.AllowUserToAddRows = false;
            this.DvgMutationLogs.AllowUserToDeleteRows = false;
            this.DvgMutationLogs.AllowUserToResizeColumns = false;
            this.DvgMutationLogs.AllowUserToResizeRows = false;
            this.DvgMutationLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DvgMutationLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DvgMutationLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgMutationLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mutationLogs});
            this.DvgMutationLogs.Location = new System.Drawing.Point(29, 325);
            this.DvgMutationLogs.MultiSelect = false;
            this.DvgMutationLogs.Name = "DvgMutationLogs";
            this.DvgMutationLogs.ReadOnly = true;
            this.DvgMutationLogs.RowTemplate.Height = 25;
            this.DvgMutationLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgMutationLogs.Size = new System.Drawing.Size(851, 171);
            this.DvgMutationLogs.TabIndex = 3;
            // 
            // mutationLogs
            // 
            this.mutationLogs.HeaderText = "Mutationslogs";
            this.mutationLogs.Name = "mutationLogs";
            this.mutationLogs.ReadOnly = true;
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DvgMutationLogs);
            this.Controls.Add(this.LblNumberOfTrainees);
            this.Controls.Add(this.LblNumberOfEmployees);
            this.Controls.Add(this.LblNumberOfCustomers);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(908, 518);
            ((System.ComponentModel.ISupportInitialize)(this.DvgMutationLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumberOfCustomers;
        private System.Windows.Forms.Label LblNumberOfEmployees;
        private System.Windows.Forms.Label LblNumberOfTrainees;
        private System.Windows.Forms.ListView LsvMutationLogs;
        private System.Windows.Forms.DataGridView DvgMutationLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn mutationLogs;
    }
}
