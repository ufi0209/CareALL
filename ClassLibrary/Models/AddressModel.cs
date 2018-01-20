using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
     [Table("Addresses")]
    public class AddressModel
    {
        public AddressModel()
        {
        }

        [Key]
        public int ID { get; set; }

        public int AddressType { get; set; }

        public string ZipCode { get; set; }

        public string Settlement { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string OtherInformation { get; set; }

        public int IsDeleted { get; set; }

        public string Comment { get; set; }
    }
}
