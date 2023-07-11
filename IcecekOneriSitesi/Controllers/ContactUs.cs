using IcecekOneriSitesi.Models;
using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Controllers
{
    [AllowAnonymous]
    public class ContactUs : Controller
    {
        MesajlarRepository mesajlarRepository = new MesajlarRepository(); 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult YorumEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YorumEkle(Models.Mesajlar p)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            mesajlarRepository.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
