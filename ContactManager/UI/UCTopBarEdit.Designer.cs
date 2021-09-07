
namespace ContactManager.UI
{
    partial class UCTopBarEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTopBarEdit));
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdSave
            // 
            this.CmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdSave.FlatAppearance.BorderSize = 0;
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmdSave.Image = global::ContactManager.Properties.Resources.save_file_5320;
            this.CmdSave.Location = new System.Drawing.Point(0, 0);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSave.Size = new System.Drawing.Size(64, 67);
            this.CmdSave.TabIndex = 14;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancle
            // 
            this.CmdCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdCancle.BackgroundImage")));
            this.CmdCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdCancle.FlatAppearance.BorderSize = 0;
            this.CmdCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmdCancle.Location = new System.Drawing.Point(64, 0);
            this.CmdCancle.Name = "CmdCancle";
            this.CmdCancle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdCancle.Size = new System.Drawing.Size(64, 67);
            this.CmdCancle.TabIndex = 13;
            this.CmdCancle.Text = "Abbrechen";
            this.CmdCancle.UseVisualStyleBackColor = true;
            this.CmdCancle.Click += new System.EventHandler(this.CmdCancle_Click);
            // 
            // UCTopBarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdCancle);
            this.Name = "UCTopBarEdit";
            this.Size = new System.Drawing.Size(778, 67);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdCancle;
    }
}
