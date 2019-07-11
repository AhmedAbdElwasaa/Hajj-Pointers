using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.BLL;

namespace WebApplication1.Models
{
    public class UnitOfWork : IDisposable
    {

        private readonly ApplicationDbContext context;
        public ApplicationUserManager UserManager { get; private set; }

        public CityManager CityManager {
            get
            {
                return new CityManager(context);
            }
          
        }

        public OfficesManager OfficeManager {
            get
            {
                return new OfficesManager(context);
            }
           
        }

        public ServicesManager ServicesManager {
            get
            {
                return new ServicesManager(context);
            }
            
        }

        public TypeOfServiceManager  TypeOfServiceManager {
            get
            {
                return new TypeOfServiceManager(context);
            }
           
        }


        public UnitOfWork(IOwinContext owincontext)
        {
            context = owincontext.Get<ApplicationDbContext>();
            UserManager = owincontext.Get<ApplicationUserManager>();

        }

        public static UnitOfWork Create(IdentityFactoryOptions<UnitOfWork> options, IOwinContext owinContext)
        {
            return new UnitOfWork(owinContext);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}