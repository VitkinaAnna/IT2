using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    [KnownType(typeof(TypeChar))]
    [KnownType(typeof(TypeHTML))]
    [KnownType(typeof(TypeInteger))]
    [KnownType(typeof(TypeReal))]
    [KnownType(typeof(TypeString))]
    [KnownType(typeof(TypeStringInvl))]

    public abstract class TypeDB
    {
        public abstract bool Validation(string value);
    }
}
