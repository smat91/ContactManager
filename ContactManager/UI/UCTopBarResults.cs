using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManager.UI
{
    public partial class UCTopBarResults : UserControl
    {
        private XDocument xdocument_;
        private XmlTemplate xmlTemplate = new XmlTemplate();                // Objekt um die XML-Templates zu erstellen
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();    // Objekt um XML-Daten zu handeln

        public UCTopBarResults(ref XDocument xdocument)
        {
            InitializeComponent();
            xdocument_ = xdocument;
        }


        private void CmdReset_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            //Combobox leeren!
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            switch (Form1.Instance.sideBarStatus)
            {
                // case customer
                case 1:
                    // Erzeugt ein neues XElement vom Typ Customer
                    XElement customerTemplate = xmlTemplate.XelementTemplateCustomer();

                    // Erzeugt ein neues objekt vom Typ Customer des vorhin erstellen Templates
                    Customer customer = new Customer(ref customerTemplate);

                    // Fügt das Customer Objekt customer dem xdocument hinzu
                    customer.AddToXDocument(ref xdocument_);

                    // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                    if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCEditCustomerObject"))
                    {
                        UI.UCEditCustomerObject un = new UI.UCEditCustomerObject();
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainerMain.Controls.Add(un);
                    }

                    // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                    if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarEdit"))
                    {
                        UI.UCTopBarEdit un = new UI.UCTopBarEdit(ref xdocument_);
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainerTop.Controls.Add(un);
                    }

                    // Der Form das zu bearbeitende customer Objekt übergebeb
                    (Form1.Instance.PnlContainerMain.Controls["UCEditCustomerObject"] as UI.UCEditCustomerObject).SetCustomer(ref customer);
                    (Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"] as UI.UCTopBarEdit).SetPersonObject(customer);

                    // Die Form in den Vordergrund bringen und anzeigen
                    Form1.Instance.PnlContainerMain.Controls["UCEditCustomerObject"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"].BringToFront();
                    break;

                // case employee
                case 2:
                    // Erzeugt ein neues XElement vom Typ Employee
                    XElement employeeTemplate = xmlTemplate.XelementTemplateEmployee();

                    // Erzeugt ein neues objekt vom Typ Employee des vorhin erstellen Templates
                    Employee employee = new Employee(ref employeeTemplate);

                    // Fügt das Employee Objekt employee dem xdocument_ hinzu
                    employee.AddToXDocument(ref xdocument_);

                    // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                    if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCEditEmployeeObject"))
                    {
                        UI.UCEditEmployeeObject un = new UI.UCEditEmployeeObject();
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainerMain.Controls.Add(un);
                    }

                    // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                    if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarEdit"))
                    {
                        UI.UCTopBarEdit un = new UI.UCTopBarEdit(ref xdocument_);
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainerTop.Controls.Add(un);
                    }

                    // Der Form das zu bearbeitende customer Objekt übergebeb
                    (Form1.Instance.PnlContainerMain.Controls["UCEditEmployeeObject"] as UI.UCEditEmployeeObject).SetEmployee(ref employee);
                    (Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"] as UI.UCTopBarEdit).SetPersonObject(employee);

                    // Die Form in den Vordergrund bringen und anzeigen
                    Form1.Instance.PnlContainerMain.Controls["UCEditEmployeeObject"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"].BringToFront();
                    break;

                // case trainee
                case 3:
                    // Erzeugt ein neues XElement vom Typ Trainee
                    XElement traineeTemplate = xmlTemplate.XelementTemplateTrainee();

                    // Erzeugt ein neues objekt vom Typ Trainee des vorhin erstellen Templates
                    Trainee trainee = new Trainee(ref traineeTemplate);

                    // Fügt das Trainee Objekt c dem xdocument_ hinzu
                    trainee.AddToXDocument(ref xdocument_);

                    // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                    if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCEditTraineeObject"))
                    {
                        UI.UCEditTraineeObject un = new UI.UCEditTraineeObject();
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainerMain.Controls.Add(un);
                    }

                    // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                    if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarEdit"))
                    {
                        UI.UCTopBarEdit un = new UI.UCTopBarEdit(ref xdocument_);
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainerTop.Controls.Add(un);
                    }

                    // Der Form das zu bearbeitende customer Objekt übergebeb
                    (Form1.Instance.PnlContainerMain.Controls["UCEditTraineeObject"] as UI.UCEditTraineeObject).SetTrainee(ref trainee);
                    (Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"] as UI.UCTopBarEdit).SetPersonObject(trainee);

                    // Die Form in den Vordergrund bringen und anzeigen
                    Form1.Instance.PnlContainerMain.Controls["UCEditTraineeObject"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"].BringToFront();
                    break;

                // default 
                default:
                    break;
            }
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            if (CheckRowSelcected())
            {
                switch (Form1.Instance.sideBarStatus)
                {
                    // case customer
                    case 1:
                        // ID aus selektierter Zeile aus dem Data Grid View auslesen
                        // Die ID steht in der ersten zelle deshalb --> SelectedCells[0]
                        string selectedIdCustomer = (Form1.Instance.PnlContainerMain.Controls["UCCustomer"].
                            Controls["DgvCustomer"] as DataGridView).SelectedCells[0].Value.ToString();

                        // Erzeugt ein neues objekt vom Typ Customer hanhand der ID kann das 
                        // bestehende XElement aus dem xdocument_ ausgelesen werden
                        Customer customer = new Customer(ref xmlDataHandling.IdToXElement(
                            ref xdocument_, XmlDataHandling.personType.customer, selectedIdCustomer));

                        // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                        if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCEditCustomerObject"))
                        {
                            UI.UCEditCustomerObject un = new UI.UCEditCustomerObject();
                            un.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainerMain.Controls.Add(un);
                        }

                        // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                        if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarEdit"))
                        {
                            UI.UCTopBarEdit un = new UI.UCTopBarEdit(ref xdocument_);
                            un.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainerTop.Controls.Add(un);
                        }

                        // Der Form das zu bearbeitende customer Objekt übergebeb
                        (Form1.Instance.PnlContainerMain.Controls["UCEditCustomerObject"] as UI.UCEditCustomerObject).SetCustomer(ref customer);
                        (Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"] as UI.UCTopBarEdit).SetPersonObject(customer);

                        // Die Form in den Vordergrund bringen und anzeigen
                        Form1.Instance.PnlContainerMain.Controls["UCEditCustomerObject"].BringToFront();
                        Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"].BringToFront();
                        break;

                    // case employee
                    case 2:
                        // ID aus selektierter Zeile aus dem Data Grid View auslesen
                        // Die ID steht in der ersten zelle deshalb --> SelectedCells[0]
                        string selectedIdEmployee = (Form1.Instance.PnlContainerMain.Controls["UCEmployee"].
                            Controls["DgvEmployee"] as DataGridView).SelectedCells[0].Value.ToString();

                        // Erzeugt ein neues objekt vom Typ Employee hanhand der ID kann das 
                        // bestehende XElement aus dem xdocument_ ausgelesen werden
                        Employee employee = new Employee(ref xmlDataHandling.IdToXElement(
                            ref xdocument_, XmlDataHandling.personType.employee, selectedIdEmployee));

                        // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                        if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCEditEmployeeObject"))
                        {
                            UI.UCEditEmployeeObject un = new UI.UCEditEmployeeObject();
                            un.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainerMain.Controls.Add(un);
                        }

                        // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                        if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarEdit"))
                        {
                            UI.UCTopBarEdit un = new UI.UCTopBarEdit(ref xdocument_);
                            un.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainerTop.Controls.Add(un);
                        }

                        // Der Form das zu bearbeitende Employee Objekt übergebeb
                        (Form1.Instance.PnlContainerMain.Controls["UCEditEmployeeObject"] as UI.UCEditEmployeeObject).SetEmployee(ref employee);
                        (Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"] as UI.UCTopBarEdit).SetPersonObject(employee);

                        // Die Form in den Vordergrund bringen und anzeigen
                        Form1.Instance.PnlContainerMain.Controls["UCEditEmployeeObject"].BringToFront();
                        Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"].BringToFront();
                        break;

                    // case trainee
                    case 3:
                        // ID aus selektierter Zeile aus dem Data Grid View auslesen
                        // Die ID steht in der ersten zelle deshalb --> SelectedCells[0]
                        string selectedIdTrainee = (Form1.Instance.PnlContainerMain.Controls["UCTrainee"].
                            Controls["DgvTrainee"] as DataGridView).SelectedCells[0].Value.ToString();

                        // Erzeugt ein neues objekt vom Typ Trainee hanhand der ID kann das 
                        // bestehende XElement aus dem xdocument_ ausgelesen werden
                        Trainee trainee = new Trainee(ref xmlDataHandling.IdToXElement(
                            ref xdocument_, XmlDataHandling.personType.trainee, selectedIdTrainee));

                        // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                        if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCEditTraineeObject"))
                        {
                            UI.UCEditTraineeObject un = new UI.UCEditTraineeObject();
                            un.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainerMain.Controls.Add(un);
                        }

                        // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                        if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarEdit"))
                        {
                            UI.UCTopBarEdit un = new UI.UCTopBarEdit(ref xdocument_);
                            un.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainerTop.Controls.Add(un);
                        }

                        // Der Form das zu bearbeitende Trainee Objekt übergebeb
                        (Form1.Instance.PnlContainerMain.Controls["UCEditTraineeObject"] as UI.UCEditTraineeObject).SetTrainee(ref trainee);
                        (Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"] as UI.UCTopBarEdit).SetPersonObject(trainee);

                        // Die Form in den Vordergrund bringen und anzeigen
                        Form1.Instance.PnlContainerMain.Controls["UCEditTraineeObject"].BringToFront();
                        Form1.Instance.PnlContainerTop.Controls["UCTopBarEdit"].BringToFront();
                        break;

                    // default 
                    default:
                        break;
                }
            }
            else
            {
                string message = "Please Select an entry or create a new entry if no one is available.";
                string caption = "Error detected in selection";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            switch (Form1.Instance.sideBarStatus)
            {
                // case customer
                case 1:
                    (Form1.Instance.PnlContainerMain.Controls["UCCustomer"].
                        Controls["DgvCustomer"] as DataGridView).DataSource = xmlDataHandling.SearchInXDocument(
                            ref xdocument_,
                            XmlDataHandling.personType.customer,
                            TxtSearch.Text,
                            (string)CmbFilter.SelectedItem);

                    xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.customer);
                    break;

                // case employee
                case 2:
                    (Form1.Instance.PnlContainerMain.Controls["UCEmployee"].
                         Controls["DgvEmployee"] as DataGridView).DataSource = xmlDataHandling.SearchInXDocument(
                             ref xdocument_,
                             XmlDataHandling.personType.employee,
                             TxtSearch.Text,
                             (string)CmbFilter.SelectedItem);
                    break;

                // case trainee
                case 3:
                    (Form1.Instance.PnlContainerMain.Controls["UCTrainee"].
                         Controls["DgvTrainee"] as DataGridView).DataSource = xmlDataHandling.SearchInXDocument(
                             ref xdocument_,
                             XmlDataHandling.personType.trainee,
                             TxtSearch.Text,
                             (string)CmbFilter.SelectedItem);
                    break;

                // default 
                default:
                    break;
            }
        }

        private void CmbFilter_Click(object sender, EventArgs e)
        {
            CmbFilter.Items.Clear();

            switch (Form1.Instance.sideBarStatus)
            {
                // case customer
                case 1:
                    // Fügt der Combobox die verfügbaren Attribue hinzu
                    foreach (string columnName in xmlDataHandling.GetColumnNames(ref xdocument_, XmlDataHandling.personType.customer))
                    {
                        CmbFilter.Items.Add(columnName);
                    }
                    break;

                // case employee
                case 2:
                    // Fügt der Combobox die verfügbaren Attribue hinzu
                    foreach (string columnName in xmlDataHandling.GetColumnNames(ref xdocument_, XmlDataHandling.personType.employee))
                    {
                        CmbFilter.Items.Add(columnName);
                    }
                    break;

                // case trainee
                case 3:
                    // Fügt der Combobox die verfügbaren Attribue hinzu
                    foreach (string columnName in xmlDataHandling.GetColumnNames(ref xdocument_, XmlDataHandling.personType.trainee))
                    {
                        CmbFilter.Items.Add(columnName);
                    }
                    break;

                // default 
                default:
                    break;
            }
        }

        private bool CheckRowSelcected()
        {
            bool selectionOk = false;
            switch (Form1.Instance.sideBarStatus)
            {
                // case customer
                case 1:
                    selectionOk = ((Form1.Instance.PnlContainerMain.Controls["UCCustomer"].
                                    Controls["DgvCustomer"] as DataGridView).SelectedCells.Count > 0);
                    break;

                // case employee
                case 2:
                    selectionOk = ((Form1.Instance.PnlContainerMain.Controls["UCEmployee"].
                                    Controls["DgvEmployee"] as DataGridView).SelectedCells.Count > 0);
                    break;

                // case trainee
                case 3:
                    selectionOk = ((Form1.Instance.PnlContainerMain.Controls["UCTrainee"].
                                Controls["DgvTrainee"] as DataGridView).SelectedCells.Count > 0);
                    break;

                // default 
                default:
                    break;
            }
            return selectionOk;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            if (CheckRowSelcected())
            {
                switch (Form1.Instance.sideBarStatus)
                {
                    // case customer
                    case 1:
                        xmlDataHandling.DeleteElementById(ref xdocument_,
                                                          XmlDataHandling.personType.customer,
                                                          (Form1.Instance.PnlContainerMain.Controls["UCCustomer"].
                                                           Controls["DgvCustomer"] as DataGridView).SelectedCells[0].Value.ToString());

                        (Form1.Instance.PnlContainerMain.Controls["UCCustomer"].Controls["DgvCustomer"] as DataGridView).DataSource =
                            xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.customer);
                        break;

                    // case employee
                    case 2:
                        xmlDataHandling.DeleteElementById(ref xdocument_,
                                                          XmlDataHandling.personType.employee,
                                                          (Form1.Instance.PnlContainerMain.Controls["UCEmployee"].
                                                           Controls["DgvEmployee"] as DataGridView).SelectedCells[0].Value.ToString());

                        (Form1.Instance.PnlContainerMain.Controls["UCEmployee"].Controls["DgvEmployee"] as DataGridView).DataSource =
                            xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.employee);
                        break;

                    // case trainee
                    case 3:
                        xmlDataHandling.DeleteElementById(ref xdocument_,
                                                          XmlDataHandling.personType.trainee,
                                                          (Form1.Instance.PnlContainerMain.Controls["UCTrainee"].
                                                           Controls["DgvTrainee"] as DataGridView).SelectedCells[0].Value.ToString());

                        (Form1.Instance.PnlContainerMain.Controls["UCTrainee"].Controls["DgvTrainee"] as DataGridView).DataSource =
                            xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.trainee);
                        break;

                    // default 
                    default:
                        break;
                }
            }
            else
            {
                string message = "Please Select an entry or create a new entry if no one is available.";
                string caption = "Error detected in selection";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }

            Form1.Instance.SaveToXml();
        }
    }
}
