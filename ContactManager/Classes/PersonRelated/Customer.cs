using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager.Classes.PersonRelated
{
    class Customer : Person
    {
        public string companyName_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("CompanyName")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("CompanyName")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string customerType_
        {
            get
            {
                return  (string)
                  (from element in person_.Descendants("CustomerType")
                   select element).First();
            }

            set
            {
                if (value.Length != 1)
                {
                    const int a = 'A';
                    const int e = 'E';

                    int customerType = char.Parse(value);

                    if (customerType >= a && customerType <= e)
                    {
                        (from element in person_.Descendants("CustomerType")
                         select element).First().SetValue(value);
                    }
                    else 
                    { 
                        throw new ArgumentException("value must be a capital letter and between A and E!");
                    }
                }
                else 
                {
                    throw new ArgumentException("value must contain one character!");
                }
                
            }
        }

        public Customer(ref IEnumerable<XElement> person)
            : base(ref person)
        {
        }

        public override string ToString()
        {
            return base.ToString() + ", " + companyName_ + ", " + customerType_;
        }
    }
}
