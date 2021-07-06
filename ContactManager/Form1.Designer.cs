
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
            this.CmdSerialize = new System.Windows.Forms.Button();
            this.CmdDeserlialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(14, 92);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(522, 351);
            this.TxtOutput.TabIndex = 0;
            // 
            // CmdSerialize
            // 
            this.CmdSerialize.Location = new System.Drawing.Point(14, 13);
            this.CmdSerialize.Name = "CmdSerialize";
            this.CmdSerialize.Size = new System.Drawing.Size(133, 73);
            this.CmdSerialize.TabIndex = 1;
            this.CmdSerialize.Text = "Serialize";
            this.CmdSerialize.UseVisualStyleBackColor = true;
            this.CmdSerialize.Click += new System.EventHandler(this.CmdSerialize_Click);
            // 
            // CmdDeserlialize
            // 
            this.CmdDeserlialize.Location = new System.Drawing.Point(154, 13);
            this.CmdDeserlialize.Name = "CmdDeserlialize";
            this.CmdDeserlialize.Size = new System.Drawing.Size(131, 73);
            this.CmdDeserlialize.TabIndex = 2;
            this.CmdDeserlialize.Text = "Deserlialize";
            this.CmdDeserlialize.UseVisualStyleBackColor = true;
            this.CmdDeserlialize.Click += new System.EventHandler(this.CmdDeserlialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.CmdDeserlialize);
            this.Controls.Add(this.CmdSerialize);
            this.Controls.Add(this.TxtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Button CmdSerialize;
        private System.Windows.Forms.Button CmdDeserlialize;
    }
}

