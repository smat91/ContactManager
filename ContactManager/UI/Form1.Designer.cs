
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
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.CmdReadAll = new System.Windows.Forms.Button();
            this.CmdReadCustomers = new System.Windows.Forms.Button();
            this.CmdReadEmployees = new System.Windows.Forms.Button();
            this.CmdReadIds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(14, 92);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOutput.Size = new System.Drawing.Size(522, 351);
            this.TxtOutput.TabIndex = 0;
            // 
            // CmdReadAll
            // 
            this.CmdReadAll.Location = new System.Drawing.Point(14, 13);
            this.CmdReadAll.Name = "CmdReadAll";
            this.CmdReadAll.Size = new System.Drawing.Size(75, 45);
            this.CmdReadAll.TabIndex = 1;
            this.CmdReadAll.Text = "read all";
            this.CmdReadAll.UseVisualStyleBackColor = true;
            this.CmdReadAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmdReadCustomers
            // 
            this.CmdReadCustomers.Location = new System.Drawing.Point(96, 12);
            this.CmdReadCustomers.Name = "CmdReadCustomers";
            this.CmdReadCustomers.Size = new System.Drawing.Size(75, 46);
            this.CmdReadCustomers.TabIndex = 2;
            this.CmdReadCustomers.Text = "create xml customer";
            this.CmdReadCustomers.UseVisualStyleBackColor = true;
            this.CmdReadCustomers.Click += new System.EventHandler(this.CmdReadCustomers_Click);
            // 
            // CmdReadEmployees
            // 
            this.CmdReadEmployees.Location = new System.Drawing.Point(178, 13);
            this.CmdReadEmployees.Name = "CmdReadEmployees";
            this.CmdReadEmployees.Size = new System.Drawing.Size(75, 45);
            this.CmdReadEmployees.TabIndex = 3;
            this.CmdReadEmployees.Text = "create customer object";
            this.CmdReadEmployees.UseVisualStyleBackColor = true;
            this.CmdReadEmployees.Click += new System.EventHandler(this.CmdReadEmployees_Click);
            // 
            // CmdReadIds
            // 
            this.CmdReadIds.Location = new System.Drawing.Point(260, 13);
            this.CmdReadIds.Name = "CmdReadIds";
            this.CmdReadIds.Size = new System.Drawing.Size(75, 45);
            this.CmdReadIds.TabIndex = 4;
            this.CmdReadIds.Text = "read IDs";
            this.CmdReadIds.UseVisualStyleBackColor = true;
            this.CmdReadIds.Click += new System.EventHandler(this.CmdReadTrainees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.CmdReadIds);
            this.Controls.Add(this.CmdReadEmployees);
            this.Controls.Add(this.CmdReadCustomers);
            this.Controls.Add(this.CmdReadAll);
            this.Controls.Add(this.TxtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Button CmdReadAll;
        private System.Windows.Forms.Button CmdReadCustomers;
        private System.Windows.Forms.Button CmdReadEmployees;
        private System.Windows.Forms.Button CmdReadIds;
    }
}

