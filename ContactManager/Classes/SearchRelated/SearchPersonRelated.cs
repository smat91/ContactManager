using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{ 
    class SearchPersonRelated
    {
       // Allgemeine Properties nach denen gesucht werden kann

        public int id_
        {
            get;
            set;
        }
    
        public string state_
        {
            get;
            set;
        }

        public string salutation_
        {
            get;
            set;
        }

        public string title_
        {
            get;
            set;
        }

        public string firstname_
        {
            get;
            set;
        }

        public string lastname_
        {
            get;
            set;
        }

        public string sex_
        {
            get;
            set;
        }

        public string function_
        {
            get;
            set;
        }

        public string street_
        {
            get;
            set;
        }

        public int number_
        {
            get;
            set;
        }

        public string city_
        {
            get;
            set;
        }

        public int zip_
        {
            get;
            set;
        }

        public string phoneBusiness_
        {
            get;
            set;
        }

        public string phoneMob_
        {
            get;
            set;
        }

        public string eMail_
        {
            get;
            set;
        }

        // XDocument mit den personenbezogenen Daten
        private XDocument personsXml_;

        public SearchPersonRelated(ref XDocument personsXml)
        {
            personsXml_ = personsXml;
        }
    }
}
