using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bilet.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bilet.Models;

namespace Bilet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TblBilet bilet = new TblBilet();
            return View(bilet);
        }

        [HttpPost]
        public IActionResult Index(TblBilet bilet)
        {
            bilet.BiletTarihi = DateTime.Now;

            BiletContext context = new BiletContext();
            context.TblBilet.Add(bilet);
            context.SaveChanges();
            return RedirectToAction("Biletim", new { isim = bilet.Ad, soyisim = bilet.Soyisim , aktivite=bilet.Aktivite,
                ticketSayisi = bilet.BiletSayisi
                });
        }

        public IActionResult Biletim(string isim, string soyisim, string aktivite, int ticketSayisi)
        {
            TblBilet bilet = new TblBilet()
            {
                Ad = isim,
                Soyisim = soyisim,
                Aktivite = aktivite,
                BiletSayisi=ticketSayisi
            };
            return View(bilet);
        }


    }
}
