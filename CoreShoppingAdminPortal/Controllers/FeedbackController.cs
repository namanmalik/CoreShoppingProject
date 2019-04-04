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
        ShopDataDbContext context;
        public FeedbackController(ShopDataDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var fed = context.Feedbacks.ToList();
            return View(fed);
        }
    }
}