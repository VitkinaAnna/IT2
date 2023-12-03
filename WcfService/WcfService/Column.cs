using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class Column
    {
        //public string ColumnName;
        //public TypeDB ColumnType;
        //public string TypeName;

        [DataMember]
        public string ColumnName;
        [DataMember]
        public TypeDB ColumnType;
        [DataMember]
        public string TypeName;

        public Column(string columnname, string columntype)
        {
            ColumnName = columnname;
            TypeName = columntype;

            switch (columntype)
            {
                case "Integer":
                    ColumnType = new TypeInteger();
                    break;
                case "Real":
                    ColumnType = new TypeReal();
                    break;
                case "Char":
                    ColumnType = new TypeChar();
                    break;
                case "String":
                    ColumnType = new TypeString();
                    break;
                case "HTLM":
                    ColumnType = new TypeHTML();
                    break;
                case "StringInvl":
                    ColumnType = new TypeStringInvl();
                    break;
                default:
                    ColumnType = new TypeString();
                    break;
            }
        }
    }
}
