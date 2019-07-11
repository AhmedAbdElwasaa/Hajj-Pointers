using Microsoft.AspNet.Identity.Owin;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.BLL
{
    public class CityManager: Repository<Cities,ApplicationDbContext>
    {
        private ApplicationDbContext context;

        public CityManager(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }

        public UnitOfWork UnitofWork
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Get<UnitOfWork>();
            }
        }
    }
}