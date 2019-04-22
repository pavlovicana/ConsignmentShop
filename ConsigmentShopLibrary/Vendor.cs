using System;
using System.Collections.Generic;
using System.Text;

namespace ConsigmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commisssion{ get; set; }
        public decimal PaymentDue { get; set; }

        public string Display
        {
            get { return string.Format("{0} {1} -${2}", FirstName, LastName, PaymentDue); }

        }

        public Vendor()
        {
            Commisssion = .5;

        }
    }
}
