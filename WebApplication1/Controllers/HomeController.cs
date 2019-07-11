using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        //public UnitOfWork UnitofWork
        //{
        //    get
        //    {
        //        return HttpContext.GetOwinContext().Get<UnitOfWork>();
        //    }
        //}
        private readonly ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
           
             
            //ApplicationUser currentUser = UnitOfWork.UserManager.FindById(id);
           // UnitofWork.OfficeManager.GetAll().ToList();

            MainViewModel homeVM;
            if (User.Identity.IsAuthenticated)
            {
                homeVM = new MainViewModel
                {
                    Cities = _context.Cities.Select(a => new SelectListItem { Text = a.Name, Value = a.Id.ToString(), Selected = true }).ToList(),
                    Offices = _context.Offices.Select(a => new SelectListItem { Text = a.Name, Value = a.Id.ToString(), Selected = true }).ToList(),
                    Services = _context.Services.Select(a => new SelectListItem { Text=a.Name,Value=a.Id.ToString(),Selected=true }).ToList()   
                };

               
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View(homeVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}