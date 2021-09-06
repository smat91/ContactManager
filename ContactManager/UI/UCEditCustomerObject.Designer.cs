
namespace ContactManager.UI
{
    partial class UCEditCustomerObject
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
            this.GrpLogs = new System.Windows.Forms.GroupBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancle = new System.Windows.Forms.Button();
            this.CmdCloseLog = new System.Windows.Forms.Button();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.CmdNewLog = new System.Windows.Forms.Button();
            this.CmdShowLog = new System.Windows.Forms.Button();
            this.DgvLogs = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).BeginInit();
            this.GrpLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // LblState
            // 
            this.LblState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(3, 5);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(40, 13);
            this.LblState.TabIndex = 0;
            this.LblState.Text = "Status:";
            // 
            // LblSalutation
            // 
            this.LblSalutation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblSalutation.Location = new System.Drawing.Point(3, 28);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(44, 13);
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
            this.CmbSalutation.Location = new System.Drawing.Point(114, 26);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(172, 21);
            this.CmbSalutation.Sorted = true;
            this.CmbSalutation.TabIndex = 3;
            this.CmbSalutation.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIndexChanged);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 215);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(3, 51);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Titel:";
            // 
            // LblSex
            // 
            this.LblSex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSex.AutoSize = true;
            this.LblSex.Location = new System.Drawing.Point(3, 120);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(64, 13);
            this.LblSex.TabIndex = 7;
            this.LblSex.Text = "Geschlecht:";
            // 
            // LblFunction
            // 
            this.LblFunction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFunction.AutoSize = true;
            this.LblFunction.Location = new System.Drawing.Point(3, 143);
            this.LblFunction.Name = "LblFunction";
            this.LblFunction.Size = new System.Drawing.Size(51, 13);
            this.LblFunction.TabIndex = 8;
            this.LblFunction.Text = "Funktion:";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(3, 166);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(67, 13);
            this.LblCompanyName.TabIndex = 9;
            this.LblCompanyName.Text = "Firmenname:";
            // 
            // LblCustomerType
            // 
            this.LblCustomerType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCustomerType.AutoSize = true;
            this.LblCustomerType.Location = new System.Drawing.Point(3, 193);
            this.LblCustomerType.Name = "LblCustomerType";
            this.LblCustomerType.Size = new System.Drawing.Size(61, 13);
            this.LblCustomerType.TabIndex = 10;
            this.LblCustomerType.Text = "Kundentyp:";
            // 
            // LblLastname
            // 
            this.LblLastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblLastname.AutoSize = true;
            this.LblLastname.Location = new System.Drawing.Point(3, 97);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(62, 13);
            this.LblLastname.TabIndex = 18;
            this.LblLastname.Text = "Nachname:";
            // 
            // LblFirstname
            // 
            this.LblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFirstname.AutoSize = true;
            this.LblFirstname.Location = new System.Drawing.Point(3, 74);
            this.LblFirstname.Name = "LblFirstname";
            this.LblFirstname.Size = new System.Drawing.Size(52, 13);
            this.LblFirstname.TabIndex = 5;
            this.LblFirstname.Text = "Vorname:";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(373, 5);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(45, 13);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Strasse:";
            // 
            // LblNumber
            // 
            this.LblNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(373, 28);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(49, 13);
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
            this.CmbCustomerType.Location = new System.Drawing.Point(114, 187);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(172, 21);
            this.CmbCustomerType.TabIndex = 19;
            this.CmbCustomerType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIndexChanged);
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(114, 49);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(172, 20);
            this.TxtTitle.TabIndex = 20;
            this.TxtTitle.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(114, 72);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(172, 20);
            this.TxtFirstname.TabIndex = 21;
            this.TxtFirstname.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(114, 95);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(172, 20);
            this.TxtLastname.TabIndex = 22;
            this.TxtLastname.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtSex
            // 
            this.TxtSex.Location = new System.Drawing.Point(114, 118);
            this.TxtSex.Name = "TxtSex";
            this.TxtSex.Size = new System.Drawing.Size(172, 20);
            this.TxtSex.TabIndex = 23;
            this.TxtSex.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtFunction
            // 
            this.TxtFunction.Location = new System.Drawing.Point(114, 141);
            this.TxtFunction.Name = "TxtFunction";
            this.TxtFunction.Size = new System.Drawing.Size(172, 20);
            this.TxtFunction.TabIndex = 24;
            this.TxtFunction.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(114, 164);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(172, 20);
            this.TxtCompanyName.TabIndex = 25;
            this.TxtCompanyName.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(484, 26);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(172, 20);
            this.TxtNumber.TabIndex = 32;
            this.TxtNumber.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(484, 3);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(172, 20);
            this.TxtStreet.TabIndex = 33;
            this.TxtStreet.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(373, 193);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "Email:";
            // 
            // LblFax
            // 
            this.LblFax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFax.AutoSize = true;
            this.LblFax.Location = new System.Drawing.Point(373, 166);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(27, 13);
            this.LblFax.TabIndex = 17;
            this.LblFax.Text = "Fax:";
            // 
            // LblPhoneMobile
            // 
            this.LblPhoneMobile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPhoneMobile.AutoSize = true;
            this.LblPhoneMobile.Location = new System.Drawing.Point(373, 143);
            this.LblPhoneMobile.Name = "LblPhoneMobile";
            this.LblPhoneMobile.Size = new System.Drawing.Size(55, 13);
            this.LblPhoneMobile.TabIndex = 16;
            this.LblPhoneMobile.Text = "Tel. mobil:";
            // 
            // LblPhoneBussines
            // 
            this.LblPhoneBussines.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPhoneBussines.AutoSize = true;
            this.LblPhoneBussines.Location = new System.Drawing.Point(373, 120);
            this.LblPhoneBussines.Name = "LblPhoneBussines";
            this.LblPhoneBussines.Size = new System.Drawing.Size(88, 13);
            this.LblPhoneBussines.TabIndex = 15;
            this.LblPhoneBussines.Text = "Tel. geschäftlich:";
            // 
            // LblCountry
            // 
            this.LblCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(373, 97);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(34, 13);
            this.LblCountry.TabIndex = 14;
            this.LblCountry.Text = "Land:";
            // 
            // LblZip
            // 
            this.LblZip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblZip.AutoSize = true;
            this.LblZip.Location = new System.Drawing.Point(373, 74);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(30, 13);
            this.LblZip.TabIndex = 13;
            this.LblZip.Text = "PLZ:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(484, 187);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(172, 20);
            this.TxtEmail.TabIndex = 26;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtFax
            // 
            this.TxtFax.Location = new System.Drawing.Point(484, 164);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(172, 20);
            this.TxtFax.TabIndex = 27;
            this.TxtFax.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtPhoneMobile
            // 
            this.TxtPhoneMobile.Location = new System.Drawing.Point(484, 141);
            this.TxtPhoneMobile.Name = "TxtPhoneMobile";
            this.TxtPhoneMobile.Size = new System.Drawing.Size(172, 20);
            this.TxtPhoneMobile.TabIndex = 28;
            this.TxtPhoneMobile.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtPhoneBussines
            // 
            this.TxtPhoneBussines.Location = new System.Drawing.Point(484, 118);
            this.TxtPhoneBussines.Name = "TxtPhoneBussines";
            this.TxtPhoneBussines.Size = new System.Drawing.Size(172, 20);
            this.TxtPhoneBussines.TabIndex = 29;
            this.TxtPhoneBussines.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(484, 95);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(172, 20);
            this.TxtCountry.TabIndex = 30;
            this.TxtCountry.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // LbLCity
            // 
            this.LbLCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbLCity.AutoSize = true;
            this.LbLCity.Location = new System.Drawing.Point(373, 51);
            this.LbLCity.Name = "LbLCity";
            this.LbLCity.Size = new System.Drawing.Size(24, 13);
            this.LbLCity.TabIndex = 34;
            this.LbLCity.Text = "Ort:";
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCity.Location = new System.Drawing.Point(484, 49);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(172, 20);
            this.TxtCity.TabIndex = 35;
            this.TxtCity.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // NumZip
            // 
            this.NumZip.Location = new System.Drawing.Point(484, 72);
            this.NumZip.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumZip.Name = "NumZip";
            this.NumZip.Size = new System.Drawing.Size(171, 20);
            this.NumZip.TabIndex = 36;
            this.NumZip.ValueChanged += new System.EventHandler(this.NummericUpDownChanged);
            // 
            // CmbState
            // 
            this.CmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Items.AddRange(new object[] {
            "Aktiv",
            "Inaktiv"});
            this.CmbState.Location = new System.Drawing.Point(114, 3);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(172, 21);
            this.CmbState.TabIndex = 37;
            this.CmbState.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIndexChanged);
            // 
            // GrpLogs
            // 
            this.GrpLogs.Controls.Add(this.CmdSave);
            this.GrpLogs.Controls.Add(this.CmdCancle);
            this.GrpLogs.Controls.Add(this.CmdCloseLog);
            this.GrpLogs.Controls.Add(this.TxtLog);
            this.GrpLogs.Controls.Add(this.CmdNewLog);
            this.GrpLogs.Controls.Add(this.CmdShowLog);
            this.GrpLogs.Controls.Add(this.DgvLogs);
            this.GrpLogs.Location = new System.Drawing.Point(12, 235);
            this.GrpLogs.Name = "GrpLogs";
            this.GrpLogs.Size = new System.Drawing.Size(742, 196);
            this.GrpLogs.TabIndex = 5;
            this.GrpLogs.TabStop = false;
            this.GrpLogs.Text = "Gesprächsnotizen";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(661, 20);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(76, 46);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Visible = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancle
            // 
            this.CmdCancle.Location = new System.Drawing.Point(661, 71);
            this.CmdCancle.Name = "CmdCancle";
            this.CmdCancle.Size = new System.Drawing.Size(76, 47);
            this.CmdCancle.TabIndex = 5;
            this.CmdCancle.Text = "Abbrechen";
            this.CmdCancle.UseVisualStyleBackColor = true;
            this.CmdCancle.Visible = false;
            this.CmdCancle.Click += new System.EventHandler(this.CmdCancle_Click);
            // 
            // CmdCloseLog
            // 
            this.CmdCloseLog.Location = new System.Drawing.Point(661, 20);
            this.CmdCloseLog.Name = "CmdCloseLog";
            this.CmdCloseLog.Size = new System.Drawing.Size(76, 46);
            this.CmdCloseLog.TabIndex = 4;
            this.CmdCloseLog.Text = "Log Schliessen";
            this.CmdCloseLog.UseVisualStyleBackColor = true;
            this.CmdCloseLog.Visible = false;
            this.CmdCloseLog.Click += new System.EventHandler(this.CmdCloseLog_Click);
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(6, 20);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.Size = new System.Drawing.Size(649, 171);
            this.TxtLog.TabIndex = 3;
            this.TxtLog.Visible = false;
            // 
            // CmdNewLog
            // 
            this.CmdNewLog.Location = new System.Drawing.Point(660, 19);
            this.CmdNewLog.Name = "CmdNewLog";
            this.CmdNewLog.Size = new System.Drawing.Size(77, 47);
            this.CmdNewLog.TabIndex = 2;
            this.CmdNewLog.Text = "Neue Notiz erstellen";
            this.CmdNewLog.UseVisualStyleBackColor = true;
            this.CmdNewLog.Click += new System.EventHandler(this.CmdNewLog_Click);
            // 
            // CmdShowLog
            // 
            this.CmdShowLog.Location = new System.Drawing.Point(660, 71);
            this.CmdShowLog.Name = "CmdShowLog";
            this.CmdShowLog.Size = new System.Drawing.Size(77, 47);
            this.CmdShowLog.TabIndex = 1;
            this.CmdShowLog.Text = "Notiz anzeigen";
            this.CmdShowLog.UseVisualStyleBackColor = true;
            this.CmdShowLog.Click += new System.EventHandler(this.CmdShowLog_Click);
            // 
            // DgvLogs
            // 
            this.DgvLogs.AllowUserToAddRows = false;
            this.DgvLogs.AllowUserToDeleteRows = false;
            this.DgvLogs.AllowUserToResizeColumns = false;
            this.DgvLogs.AllowUserToResizeRows = false;
            this.DgvLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLogs.Location = new System.Drawing.Point(5, 19);
            this.DgvLogs.MultiSelect = false;
            this.DgvLogs.Name = "DgvLogs";
            this.DgvLogs.ReadOnly = true;
            this.DgvLogs.RowTemplate.Height = 25;
            this.DgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLogs.Size = new System.Drawing.Size(650, 172);
            this.DgvLogs.TabIndex = 0;
            this.DgvLogs.SelectionChanged += new System.EventHandler(this.DgvLogs_SelectionChanged);
            // 
            // UCEditCustomerObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrpLogs);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCEditCustomerObject";
            this.Size = new System.Drawing.Size(778, 449);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).EndInit();
            this.GrpLogs.ResumeLayout(false);
            this.GrpLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLogs)).EndInit();
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
        private System.Windows.Forms.GroupBox GrpLogs;
        private System.Windows.Forms.Button CmdNewLog;
        private System.Windows.Forms.Button CmdShowLog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView DgvLogs;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button CmdCloseLog;
        private System.Windows.Forms.Button CmdCancle;
        private System.Windows.Forms.Button CmdSave;
    }
}
