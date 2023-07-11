using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Controllers
{
    public class Mesajlar : Controller
    {
        MesajlarRepository mesajlarRepository = new MesajlarRepository();
        public IActionResult Index()
        {
            return View(mesajlarRepository.TList());
        }
        public IActionResult MesajlarGet(int id)
        {
            var x = mesajlarRepository.TGet(id);
            Models.Mesajlar ct = new()
            {
                MesajID = x.MesajID,
                MesajGonderen = x.MesajGonderen,
                MesajBaslik = x.MesajBaslik,
                MesajMail=x.MesajMail,
                MesajTarih=x.MesajTarih,
                MesajIcerik=x.MesajIcerik
            };
            return View(ct);
        }
        public IActionResult MesajSil(int id)
        {
            mesajlarRepository.TDelete(new Models.Mesajlar { MesajID = id });
            return RedirectToAction("Index");
        }
    }
}
