using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    [Table("AddresToPersonOrOrganization")]
    public class AddresToPersonOrOrganizationModel
    {
        public AddresToPersonOrOrganizationModel()
        {
        }

        [Key]
        public int ID { get; set; }

        public int AddressID { get; set; }

        public int ConnectionID { get; set; }

        public int IsDeleted { get; set; }

        public string Comment { get; set; }
    }
}
