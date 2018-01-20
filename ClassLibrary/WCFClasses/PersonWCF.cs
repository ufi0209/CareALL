using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.WCFClasses
{
    [DataContract]
    class PersonWCF
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public string BirthPlace { get; set; }
        [DataMember]
        public string MothersFirstName { get; set; }
        [DataMember]
        public string MothersMiddleName { get; set; }
        [DataMember]
        public string MothersLastName { get; set; }
        [DataMember]
        public string TaxNumber { get; set; }
        [DataMember]
        public int IsDeleted { get; set; }
        [DataMember]
        public string Comment { get; set; }
    }
}
