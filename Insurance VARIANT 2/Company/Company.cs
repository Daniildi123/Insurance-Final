using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_VARIANT_2.Company
{
    public abstract class Company
    {
        public abstract string CompanyName { get; set; }

        public abstract string CompanyPhoneNumber { get; set; }

        public abstract string CompanyAddress { get; set; }
    }
}
