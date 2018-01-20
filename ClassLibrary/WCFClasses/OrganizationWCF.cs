using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.WCFClasses
{
    [DataContract]
    class OrganizationWCF
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string TaxNumber { get; set; }
        [DataMember]
        public string CompanyValue { get; set; }
        [DataMember]
        public int IsDeleted { get; set; }
        [DataMember]
        public string Comment { get; set; }
    }
}
