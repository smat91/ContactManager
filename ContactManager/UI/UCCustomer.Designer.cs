
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
            this.UCCustomer = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UCCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // UCCustomer
            // 
            this.UCCustomer.Controls.Add(this.textBox1);
            this.UCCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCCustomer.Location = new System.Drawing.Point(0, 0);
            this.UCCustomer.Name = "UCCustomer";
            this.UCCustomer.Size = new System.Drawing.Size(1088, 634);
            this.UCCustomer.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Customer";
            // 
            // UCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UCCustomer);
            this.Name = "UCustomer";
            this.Size = new System.Drawing.Size(1088, 634);
            this.UCCustomer.ResumeLayout(false);
            this.UCCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UCCustomer;
        private System.Windows.Forms.TextBox textBox1;
    }
}
