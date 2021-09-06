
namespace ContactManager.UI
{
    partial class UCCustomer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Customer";
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.AllowUserToAddRows = false;
            this.DgvCustomer.AllowUserToDeleteRows = false;
            this.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.DgvCustomer.MultiSelect = false;
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.ReadOnly = true;
            this.DgvCustomer.RowTemplate.Height = 25;
            this.DgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCustomer.Size = new System.Drawing.Size(908, 518);
            this.DgvCustomer.TabIndex = 1;
            // 
            // UCCustomer
            // 
            this.Controls.Add(this.DgvCustomer);
            this.Name = "UCCustomer";
            this.Size = new System.Drawing.Size(1088, 634);
            this.Load += new System.EventHandler(this.UCCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DgvCustomer;
    }
}
