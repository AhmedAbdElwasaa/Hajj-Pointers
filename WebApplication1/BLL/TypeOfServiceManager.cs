﻿using Microsoft.AspNet.Identity.Owin;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.BLL
{
    public class TypeOfServiceManager: Repository<TypeOfService,ApplicationDbContext>
    {
        private ApplicationDbContext context;

        public TypeOfServiceManager(ApplicationDbContext context):base(context)
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
    }
}