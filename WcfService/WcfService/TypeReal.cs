using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    class TypeReal : TypeDB
    {
        public override bool Validation(string value)
        {
            double buf;
            if (double.TryParse(value, out buf)) return true;
            return false;
        }
    }
}
