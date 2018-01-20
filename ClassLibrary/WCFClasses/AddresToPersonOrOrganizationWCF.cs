using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.WCFClasses
{
    [DataContract]
    class AddresToPersonOrOrganizationWCF
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int AddressID { get; set; }
        [DataMember]
        public int ConnectionID { get; set; }
        [DataMember]
        public int IsDeleted { get; set; }
        [DataMember]
        public string Comment { get; set; }
    }
}
