using Microsoft.AspNetCore.Mvc;


namespace SindicoWeb.Controllers

{
    public class Servico : Controller
    {

        public IActionResult ServicosPage()
        {
            return View();
        }

    }

}