using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class TypeHTML : TypeDB
    {
        public override bool Validation(string value)
        {
            if (value.EndsWith(".html", StringComparison.OrdinalIgnoreCase))
            {
                /*if (File.Exists(value))
                {
                    return true;
                }*/
            }

            return false;
        }
    }
}
