
namespace ContactManager.UI
{
    partial class UCEditCustomer
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
            this.LblState = new System.Windows.Forms.Label();
            this.LblSalutation = new System.Windows.Forms.Label();
            this.CmbSalutation = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblSex = new System.Windows.Forms.Label();
            this.LblFunction = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.LblCustomerType = new System.Windows.Forms.Label();
            this.LblLastname = new System.Windows.Forms.Label();
            this.LblFirstname = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.CmbCustomerType = new System.Windows.Forms.ComboBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtSex = new System.Windows.Forms.TextBox();
            this.TxtFunction = new System.Windows.Forms.TextBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblFax = new System.Windows.Forms.Label();
            this.LblPhoneMobile = new System.Windows.Forms.Label();
            this.LblPhoneBussines = new System.Windows.Forms.Label();
            this.LblCountry = new System.Windows.Forms.Label();
            this.LblZip = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.TxtPhoneMobile = new System.Windows.Forms.TextBox();
            this.TxtPhoneBussines = new System.Windows.Forms.TextBox();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.LbLCity = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.NumZip = new System.Windows.Forms.NumericUpDown();
            this.CmbState = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).BeginInit();
            this.SuspendLayout();
            // 
            // LblState
            // 
            this.LblState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(3, 6);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(42, 15);
            this.LblState.TabIndex = 0;
            this.LblState.Text = "Status:";
            // 
            // LblSalutation
            // 
            this.LblSalutation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblSalutation.Location = new System.Drawing.Point(3, 33);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(48, 15);
            this.LblSalutation.TabIndex = 2;
            this.LblSalutation.Text = "Anrede:";
            this.LblSalutation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Items.AddRange(new object[] {
            "Frau",
            "Herr"});
            this.CmbSalutation.Location = new System.Drawing.Point(132, 30);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(200, 23);
            this.CmbSalutation.Sorted = true;
            this.CmbSalutation.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.CmbSalutation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblSalutation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblState, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblSex, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblFunction, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LblCompanyName, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblCustomerType, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.LblLastname, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblFirstname, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblStreet, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CmbCustomerType, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.TxtTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtFirstname, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtLastname, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtSex, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtFunction, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtCompanyName, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtNumber, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtStreet, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblEmail, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.LblFax, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblPhoneMobile, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.LblPhoneBussines, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblCountry, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblZip, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmail, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.TxtFax, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtPhoneMobile, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtPhoneBussines, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtCountry, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.LbLCity, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtCity, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.NumZip, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.CmbState, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 248);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(3, 60);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(32, 15);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Titel:";
            // 
            // LblSex
            // 
            this.LblSex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSex.AutoSize = true;
            this.LblSex.Location = new System.Drawing.Point(3, 141);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(68, 15);
            this.LblSex.TabIndex = 7;
            this.LblSex.Text = "Geschlecht:";
            // 
            // LblFunction
            // 
            this.LblFunction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFunction.AutoSize = true;
            this.LblFunction.Location = new System.Drawing.Point(3, 168);
            this.LblFunction.Name = "LblFunction";
            this.LblFunction.Size = new System.Drawing.Size(57, 15);
            this.LblFunction.TabIndex = 8;
            this.LblFunction.Text = "Funktion:";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(3, 195);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(77, 15);
            this.LblCompanyName.TabIndex = 9;
            this.LblCompanyName.Text = "Firmenname:";
            // 
            // LblCustomerType
            // 
            this.LblCustomerType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCustomerType.AutoSize = true;
            this.LblCustomerType.Location = new System.Drawing.Point(3, 224);
            this.LblCustomerType.Name = "LblCustomerType";
            this.LblCustomerType.Size = new System.Drawing.Size(68, 15);
            this.LblCustomerType.TabIndex = 10;
            this.LblCustomerType.Text = "Kundentyp:";
            // 
            // LblLastname
            // 
            this.LblLastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblLastname.AutoSize = true;
            this.LblLastname.Location = new System.Drawing.Point(3, 114);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(68, 15);
            this.LblLastname.TabIndex = 18;
            this.LblLastname.Text = "Nachname:";
            // 
            // LblFirstname
            // 
            this.LblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFirstname.AutoSize = true;
            this.LblFirstname.Location = new System.Drawing.Point(3, 87);
            this.LblFirstname.Name = "LblFirstname";
            this.LblFirstname.Size = new System.Drawing.Size(57, 15);
            this.LblFirstname.TabIndex = 5;
            this.LblFirstname.Text = "Vorname:";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(435, 6);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 15);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Strasse:";
            // 
            // LblNumber
            // 
            this.LblNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(435, 33);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(58, 15);
            this.LblNumber.TabIndex = 12;
            this.LblNumber.Text = "Nummer:";
            // 
            // CmbCustomerType
            // 
            this.CmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.CmbCustomerType.Location = new System.Drawing.Point(132, 219);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(200, 23);
            this.CmbCustomerType.TabIndex = 19;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(132, 57);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(200, 23);
            this.TxtTitle.TabIndex = 20;
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(132, 84);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(200, 23);
            this.TxtFirstname.TabIndex = 21;
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(132, 111);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(200, 23);
            this.TxtLastname.TabIndex = 22;
            // 
            // TxtSex
            // 
            this.TxtSex.Location = new System.Drawing.Point(132, 138);
            this.TxtSex.Name = "TxtSex";
            this.TxtSex.Size = new System.Drawing.Size(200, 23);
            this.TxtSex.TabIndex = 23;
            // 
            // TxtFunction
            // 
            this.TxtFunction.Location = new System.Drawing.Point(132, 165);
            this.TxtFunction.Name = "TxtFunction";
            this.TxtFunction.Size = new System.Drawing.Size(200, 23);
            this.TxtFunction.TabIndex = 24;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(132, 192);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(200, 23);
            this.TxtCompanyName.TabIndex = 25;
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(564, 30);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(200, 23);
            this.TxtNumber.TabIndex = 32;
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(564, 3);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(200, 23);
            this.TxtStreet.TabIndex = 33;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(435, 224);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(39, 15);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "Email:";
            // 
            // LblFax
            // 
            this.LblFax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFax.AutoSize = true;
            this.LblFax.Location = new System.Drawing.Point(435, 195);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(28, 15);
            this.LblFax.TabIndex = 17;
            this.LblFax.Text = "Fax:";
            // 
            // LblPhoneMobile
            // 
            this.LblPhoneMobile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPhoneMobile.AutoSize = true;
            this.LblPhoneMobile.Location = new System.Drawing.Point(435, 168);
            this.LblPhoneMobile.Name = "LblPhoneMobile";
            this.LblPhoneMobile.Size = new System.Drawing.Size(61, 15);
            this.LblPhoneMobile.TabIndex = 16;
            this.LblPhoneMobile.Text = "Tel. mobil:";
            // 
            // LblPhoneBussines
            // 
            this.LblPhoneBussines.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPhoneBussines.AutoSize = true;
            this.LblPhoneBussines.Location = new System.Drawing.Point(435, 141);
            this.LblPhoneBussines.Name = "LblPhoneBussines";
            this.LblPhoneBussines.Size = new System.Drawing.Size(94, 15);
            this.LblPhoneBussines.TabIndex = 15;
            this.LblPhoneBussines.Text = "Tel. geschäftlich:";
            // 
            // LblCountry
            // 
            this.LblCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(435, 114);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(36, 15);
            this.LblCountry.TabIndex = 14;
            this.LblCountry.Text = "Land:";
            // 
            // LblZip
            // 
            this.LblZip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblZip.AutoSize = true;
            this.LblZip.Location = new System.Drawing.Point(435, 87);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(30, 15);
            this.LblZip.TabIndex = 13;
            this.LblZip.Text = "PLZ:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(564, 219);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(200, 23);
            this.TxtEmail.TabIndex = 26;
            // 
            // TxtFax
            // 
            this.TxtFax.Location = new System.Drawing.Point(564, 192);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(200, 23);
            this.TxtFax.TabIndex = 27;
            // 
            // TxtPhoneMobile
            // 
            this.TxtPhoneMobile.Location = new System.Drawing.Point(564, 165);
            this.TxtPhoneMobile.Name = "TxtPhoneMobile";
            this.TxtPhoneMobile.Size = new System.Drawing.Size(200, 23);
            this.TxtPhoneMobile.TabIndex = 28;
            // 
            // TxtPhoneBussines
            // 
            this.TxtPhoneBussines.Location = new System.Drawing.Point(564, 138);
            this.TxtPhoneBussines.Name = "TxtPhoneBussines";
            this.TxtPhoneBussines.Size = new System.Drawing.Size(200, 23);
            this.TxtPhoneBussines.TabIndex = 29;
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(564, 111);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(200, 23);
            this.TxtCountry.TabIndex = 30;
            // 
            // LbLCity
            // 
            this.LbLCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbLCity.AutoSize = true;
            this.LbLCity.Location = new System.Drawing.Point(435, 60);
            this.LbLCity.Name = "LbLCity";
            this.LbLCity.Size = new System.Drawing.Size(27, 15);
            this.LbLCity.TabIndex = 34;
            this.LbLCity.Text = "Ort:";
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCity.Location = new System.Drawing.Point(564, 57);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(200, 23);
            this.TxtCity.TabIndex = 35;
            // 
            // NumZip
            // 
            this.NumZip.Location = new System.Drawing.Point(564, 84);
            this.NumZip.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumZip.Name = "NumZip";
            this.NumZip.Size = new System.Drawing.Size(200, 23);
            this.NumZip.TabIndex = 36;
            // 
            // CmbState
            // 
            this.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Items.AddRange(new object[] {
            "Aktiv",
            "Inaktiv"});
            this.CmbState.Location = new System.Drawing.Point(132, 3);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(200, 23);
            this.CmbState.TabIndex = 37;
            this.CmbState.SelectedIndexChanged += new System.EventHandler(this.CmbState_SelectedIndexChanged);
            // 
            // UCEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCEditCustomer";
            this.Size = new System.Drawing.Size(908, 518);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Label LblSalutation;
        private System.Windows.Forms.ComboBox CmbSalutation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblFirstname;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblSex;
        private System.Windows.Forms.Label LblFunction;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.Label LblCustomerType;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblZip;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.Label LblPhoneBussines;
        private System.Windows.Forms.Label LblPhoneMobile;
        private System.Windows.Forms.Label LblFax;
        private System.Windows.Forms.Label LblLastname;
        private System.Windows.Forms.ComboBox CmbCustomerType;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.TextBox TxtSex;
        private System.Windows.Forms.TextBox TxtFunction;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtFax;
        private System.Windows.Forms.TextBox TxtPhoneMobile;
        private System.Windows.Forms.TextBox TxtPhoneBussines;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Label LbLCity;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.NumericUpDown NumZip;
        private System.Windows.Forms.ComboBox CmbState;
    }
}
