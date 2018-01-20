using WcfService.DataAccessLayer;
using ClassLibrary.WCFClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddAddress(AddressWCF address)
        {
            using (var ctx = new DBContext())
            {
                //INIT(ctx);

                ctx.Addresses.Add(new ClassLibrary.Models.AddressModel()
                {
                    AddressType = address.AddressType,
                    Comment = address.Comment,
                    HouseNumber = address.HouseNumber,
                    IsDeleted = address.IsDeleted,
                    OtherInformation = address.OtherInformation,
                    Settlement = address.Settlement,
                    Street = address.Street,
                    ZipCode = address.ZipCode,

                });

                ctx.SaveChanges();
            }
        }

        public AddressWCF GetAddress(int value)
        {
            using (var ctx = new DBContext())
            {
                INIT(ctx);
                return ctx.Addresses.Where(m => m.ID == value).
                    Select(m => new AddressWCF() { ID = m.ID, Comment = m.Comment }).FirstOrDefault();
            }

        }


        public void INIT(DBContext ctx)
        {
            //ctx.Database.Delete();
            if (!ctx.Database.Exists())
            {
                ctx.Database.CreateIfNotExists();
                //példa adatok jönnek majd ide!
            }
 
        }
    }
}
