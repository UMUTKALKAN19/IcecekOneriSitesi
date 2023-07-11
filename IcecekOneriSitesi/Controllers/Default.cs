using IcecekOneriSitesi.Models;
using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Controllers
{
    [AllowAnonymous]
    public class Default : Controller
    {
        Context c = new Context();
        IceceklerRepository ıceceklerRepository = new IceceklerRepository();
        public IActionResult Index()
        {
            return View(ıceceklerRepository.TList());
        }

        public IActionResult KategoriDetay(int id)
        {
            ViewBag.x = id;
            return View();
        }

        public IActionResult IcecekListe(int id)
        {
            ViewBag.y = id;
            return View();
        }
    }
}
