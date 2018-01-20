using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService.DataAccessLayer
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("ServiceContext")
        {
        }

        public DbSet<ClassLibrary.Models.AddressModel> Addresses { get; set; }
        //public DbSet<ClassLibrary.Models.AddresToPersonOrOrganizationModel> AddressConnections { get; set; }
        //public DbSet<ClassLibrary.Models.OrganizationModel> Organizations { get; set; }
        //public DbSet<ClassLibrary.Models.PersonModel> Persons { get; set; }
        //public DbSet<ClassLibrary.Models.PersonToOrganizationModel> PersonAndOrganizationConnections { get; set; }
    
    }
}