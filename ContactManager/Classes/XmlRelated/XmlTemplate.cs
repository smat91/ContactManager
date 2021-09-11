using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    class XmlTemplate
    {
        // Mit diesem Befehl wird ein XElement Template von Person erzeugt und ausgegenben
        private XElement XelementTemplatePerson()
        {
            return new XElement("Person",
                            new XElement("Id", ""),
                            new XElement("Status", "Aktiv"),
                            new XElement("Begrüssung", "Frau"),
                            new XElement("Titel", ""),
                            new XElement("Vorname", ""),
                            new XElement("Nachname", ""),
                            new XElement("Geschlecht", ""),
                            new XElement("Funktion", ""),
                            new XElement("Address",
                                new XElement("Strasse", ""),
                                new XElement("Nummer", ""),
                                new XElement("Land", ""),
                                new XElement("Ort", ""),
                                new XElement("PLZ", "1000")
                                ),
                            new XElement("ContactData",
                                new XElement("Telefon", "",
                                    new XAttribute("Type", "geschäftlich")),
                                new XElement("Telefon", "",
                                    new XAttribute("Type", "mobil")),
                                new XElement("EMail", "bsp@bsp.ch")
                                ),
                            new XElement("MutationLogs", "")
                       );
        }

        // Mit diesem Befehl wird ein XElement Template von Customer erzeugt und ausgegenben
        public XElement XelementTemplateCustomer()
        {
            XElement customer = XelementTemplatePerson();

            // Person Element von Basis nach Customer umbenennen
            customer.Name = "Customer";

            // Neue kundenbezogene Allgemeinattribute hinzufügen
            customer.Descendants("Funktion").FirstOrDefault()
                .AddAfterSelf(new XElement("Firmenname", ""),
                              new XElement("Kundentyp", "A"));

            // Neue kundenbezogene Kontaktattribute hinzufügen
            customer.Descendants("Telefon")
                .Where(element => (string)element.Attribute("Type") == "mobil")
                .FirstOrDefault()
                .AddAfterSelf(new XElement("Fax", ""));

            // Neue kundenbezogene Gesprächsattribute hinzufügen
            // Gesprächsnotizen werden über eine eigene Klasse hinzugefügt
            customer.Add(new XElement("Logs"));

            return customer;
        }

        // Mit dieser Methode wird ein XElement Template von Employee erzeugt und ausgegenben
        public XElement XelementTemplateEmployee()
        {
            XElement employee = XelementTemplatePerson();

            // Person Element von Basis nach Customer umbenennen
            employee.Name = "Employee";

            // Neue mitarbeiterbezogene Allgemeinattribute hinzufügen
            employee.Descendants("Funktion").FirstOrDefault()
                .AddAfterSelf(new XElement("Geburtsdatum", ""),
                              new XElement("Abteilung", ""),
                              new XElement("Versicherungsnummer", ""),
                              new XElement("Nationalität", ""),
                              new XElement("Eintrittsdatum", ""),
                              new XElement("Austrittsdatum", ""),
                              new XElement("Beschäftigungsgrad", "10"),
                              new XElement("Kaderstufe", "0"));

            // Neue mitarbeiterbezogene Kontaktattribute hinzufügen
            employee.Descendants("Telefon")
                .Where(element => (string)element.Attribute("Type") == "mobil")
                .FirstOrDefault()
                .AddAfterSelf(new XElement("Telefon", "",
                                    new XAttribute("Type", "privat")));

            return employee;
        }

        // Mit dieser Methode wird ein XElement Template von Employee erzeugt und ausgegenben
        public XElement XelementTemplateTrainee()
        {
            XElement trainee = XelementTemplateEmployee();

            // Person Element von Basis nach Customer umbenennen
            trainee.Name = "Trainee";

            // Neue mitarbeiterbezogene Allgemeinattribute hinzufügen
            trainee.Descendants("Kaderstufe").FirstOrDefault()
                .AddAfterSelf(new XElement("Lehrjahre", "1"),
                              new XElement("Lehrjahr", "1"));

            return trainee;
        }
    }
}
