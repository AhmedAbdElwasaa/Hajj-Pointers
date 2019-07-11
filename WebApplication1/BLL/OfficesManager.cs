using Microsoft.AspNet.Identity.Owin;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.BLL
{
    public class OfficesManager: Repository<Offices,ApplicationDbContext>
    {
        private ApplicationDbContext context;

        public OfficesManager(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }

        public UnitOfWork UnitOfWork
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Get<UnitOfWork>();
            }
        }
        //public bool UPADTE(int PASSW)
        //{

        //    string id = User.Identity.GetUserId();
        //    var user = _context.Users.Find(id);
        //    user.  = PASSW;


        //}
    }
}