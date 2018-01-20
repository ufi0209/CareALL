using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    [Table("Organizations")]
    public class OrganizationModel
    {
        public OrganizationModel()
        {
        }

        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string TaxNumber { get; set; }

        public string CompanyValue { get; set; }

        public int IsDeleted { get; set; }

        public string Comment { get; set; }


    }        
}
