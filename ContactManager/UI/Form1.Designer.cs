
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
            this.CmdReadAll = new System.Windows.Forms.Button();
            this.CmdReadCustomers = new System.Windows.Forms.Button();
            this.CmdReadEmployees = new System.Windows.Forms.Button();
            this.CmdReadIds = new System.Windows.Forms.Button();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxAttribut = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(14, 136);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOutput.Size = new System.Drawing.Size(522, 351);
            this.TxtOutput.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(565, 136);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(523, 351);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "get selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxAttribut
            // 
            this.comboBoxAttribut.FormattingEnabled = true;
            this.comboBoxAttribut.Location = new System.Drawing.Point(545, 41);
            this.comboBoxAttribut.Name = "comboBoxAttribut";
            this.comboBoxAttribut.Size = new System.Drawing.Size(464, 23);
            this.comboBoxAttribut.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(545, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(464, 23);
            this.txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1016, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 52);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "delete Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "show logs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comboBoxAttribut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdReadIds);
            this.Controls.Add(this.CmdReadEmployees);
            this.Controls.Add(this.CmdReadCustomers);
            this.Controls.Add(this.CmdReadAll);
            this.Controls.Add(this.TxtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdReadAll;
        private System.Windows.Forms.Button CmdReadCustomers;
        private System.Windows.Forms.Button CmdReadEmployees;
        private System.Windows.Forms.Button CmdReadIds;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxAttribut;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

