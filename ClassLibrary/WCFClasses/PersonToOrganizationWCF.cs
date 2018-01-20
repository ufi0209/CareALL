using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.WCFClasses
{
    [DataContract]
    class PersonToOrganizationWCF
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int PersonID { get; set; }
        [DataMember]
        public int OrganizationID { get; set; }
        [DataMember]
        public int IsDeleted { get; set; }
        [DataMember]
        public string Comment { get; set; }
    }
}
