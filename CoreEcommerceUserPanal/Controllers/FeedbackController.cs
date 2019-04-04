using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEcommerceUserPanal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreEcommerceUserPanal.Controllers
{
    public class FeedbackController : Controller
    {
        ShoppingProjectContext context =new ShoppingProjectContext();
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Feedbacks fed)
        {
            context.Feedbacks.Add(fed);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}