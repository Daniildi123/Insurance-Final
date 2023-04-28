using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_VARIANT_2.Human
{
    public class Police : People
    {
        public override string Name { get; set; }
        public override string LastName { get; set; }

        public string OfficerBadgeNumber { get; set; }
    }
}
