using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ClassLibrary.WCFClasses
{
    [DataContract]
    public class AddressWCF
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int AddressType { get; set; }
        [DataMember]
        public string ZipCode { get; set; }
        [DataMember]
        public string Settlement { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string HouseNumber { get; set; }
        [DataMember]
        public string OtherInformation { get; set; }
        [DataMember]
        public int IsDeleted { get; set; }
        [DataMember]
        public string Comment { get; set; }
    }
}
