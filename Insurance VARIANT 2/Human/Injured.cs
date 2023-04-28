using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_VARIANT_2.Human
{
    public class Injured : People
    {
        public override string Name { get; set; }
        public override string LastName { get; set; }

        public string CarName { get; set; }

        public string AccidentCircumstances { get; set; }
    }
}
