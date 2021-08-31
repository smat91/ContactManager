﻿using System;
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
                            new XElement("State", ""),
                            new XElement("Salutation", ""),
                            new XElement("Titel", ""),
                            new XElement("FirstName", ""),
                            new XElement("LastName", ""),
                            new XElement("Sex", ""),
                            new XElement("Function", ""),
                            new XElement("Address",
                                new XElement("Street", ""),
                                new XElement("Number", ""),
                                new XElement("Land", ""),
                                new XElement("City", ""),
                                new XElement("Zip", "")
                                ),
                            new XElement("ContactData",
                                new XElement("Phone", "",
                                    new XAttribute("Type", "Business")),
                                new XElement("Phone", "",
                                    new XAttribute("Type", "Mobile")),
                                new XElement("EMail", "")
                                )
                       );
        }

        // Mit diesem Befehl wird ein XElement Template von Customer erzeugt und ausgegenben
        public XElement XelementTemplateCustomer()
        {
            XElement customer = XelementTemplatePerson();

            // Person Element von Basis nach Customer umbenennen
            customer.Name = "Customer";

            // Neue kundenbezogene Allgemeinattribute hinzufügen
            customer.Descendants("Function").FirstOrDefault()
                .AddAfterSelf(new XElement("CompanyName", ""),
                              new XElement("CustomerType", ""));

            // Neue kundenbezogene Kontaktattribute hinzufügen
            customer.Descendants("Phone")
                .Where(element => (string)element.Attribute("Type") == "Mobile")
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
            employee.Descendants("Function").FirstOrDefault()
                .AddAfterSelf(new XElement("DateOfBirth", ""),
                              new XElement("Department", ""),
                              new XElement("InsuranceNumber", ""),
                              new XElement("Citizenship", ""),
                              new XElement("EntryDate", ""),
                              new XElement("SeparationDate", ""),
                              new XElement("LevelOfEmployment", ""),
                              new XElement("Level", ""));

            // Neue mitarbeiterbezogene Kontaktattribute hinzufügen
            employee.Descendants("Phone")
                .Where(element => (string)element.Attribute("Type") == "Mobile")
                .FirstOrDefault()
                .AddAfterSelf(new XElement("Phone", "",
                                    new XAttribute("Type", "Privat")));

            return employee;
        }

        // Mit dieser Methode wird ein XElement Template von Employee erzeugt und ausgegenben
        public XElement XelementTemplateTrainee()
        {
            XElement trainee = XelementTemplateEmployee();

            // Person Element von Basis nach Customer umbenennen
            trainee.Name = "Trainee";

            // Neue mitarbeiterbezogene Allgemeinattribute hinzufügen
            trainee.Descendants("Function").FirstOrDefault()
                .AddAfterSelf(new XElement("NumberOfTraineeYears", ""),
                              new XElement("CurrentTraineeYear", ""));

            return trainee;
        }

    }
}