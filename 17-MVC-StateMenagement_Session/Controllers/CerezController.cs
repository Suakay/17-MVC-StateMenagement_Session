using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace _17_MVC_StateMenagement_Session.Controllers
{
    public class CerezController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Append("Ad", "Bilge Adam");
            HttpContext.Response.Cookies.Append("personelYasi", "25");
            HttpContext.Response.Cookies.Append("personelÖaili", "bilge@bilgeadam.com");
            HttpContext.Response.Cookies.Append("PERSONELrOLU", "KULLANICI");
            return View();
            
        }
        public IActionResult Cerez()
        {
            string ad = CerezGetir("Ad");
            string peronelYasi = CerezGetir("personelYasi");
            string personelMaili = CerezGetir("personelMaili");
            string personelRolu = CerezGetir("personelRolu");

            ViewBag.prsAdi = ad;
            ViewBag.prsAdi = peronelYasi;
            ViewBag.prsAdi = personelMaili;
            ViewBag.prsAdi = personelRolu;

        }

        private string CerezGetir(string key)
        {
            HttpContext.Request.Cookies.TryGetValue(key, out var value);
            return value;
        }
    }
}
