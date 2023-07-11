using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.ViewComponents
{
    public class KategoriGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            KategorilerRepository kategorilerRepository = new KategorilerRepository();
            var kategorilist = kategorilerRepository.List(x=>x.KategoriDurum==true);
            return View(kategorilist);
        }
    }
}
