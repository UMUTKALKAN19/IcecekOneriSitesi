using IcecekOneriSitesi.Models;
using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.ViewComponents
{
    public class IcecekDetay : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            IceceklerRepository iceceklerRepository = new IceceklerRepository();
            var item = iceceklerRepository.TList();
            return View(item);
        }
    }
}
