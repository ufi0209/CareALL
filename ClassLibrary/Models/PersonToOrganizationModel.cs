using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    [Table("PersonToOrganization")]
    public class PersonToOrganizationModel
    {
        public PersonToOrganizationModel()
        {
        }

        [Key]
        public int ID { get; set; }

        public int PersonID { get; set; }

        public int OrganizationID { get; set; }

        public int IsDeleted { get; set; }

        public string Comment { get; set; }
    }
}
