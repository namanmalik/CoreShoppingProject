﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreEcommerceUserPanal.Models;
using CoreEcommerceUserPanal.Helpers;
using Microsoft.AspNetCore.Http;

namespace CoreEcommerceUserPanal.Controllers
{
    public class HomeController : Controller
    {
        ShoppingProjectContext context = new ShoppingProjectContext();
        public IActionResult Index()
        {
            var product = context.Products.ToList();
            int j = 0;
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int i = 0;
            if (cart != null)
            {
                foreach (var item in cart)
                {
                    i++;
                }
                if (i != 0)
                {
                    foreach (var i1 in cart)
                    {
                        j++;
                    }
                    HttpContext.Session.SetString("cartitem", j.ToString());
                }
            }
            return View(product);
        }
        public IActionResult AboutUs()
        {
            
            return View();
        }
    }
}
