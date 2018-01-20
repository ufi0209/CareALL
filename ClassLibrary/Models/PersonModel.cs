using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    [Table("Persons")]
    public class PersonModel
    {
        public PersonModel()
        {
        }

        [Key]
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string BirthPlace { get; set; }

        public string MothersFirstName { get; set; }

        public string MothersMiddleName { get; set; }

        public string MothersLastName { get; set; }

        public string TaxNumber { get; set; }

        public int IsDeleted { get; set; }

        public string Comment { get; set; }


    }
}
