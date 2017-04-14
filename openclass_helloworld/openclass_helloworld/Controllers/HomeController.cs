using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace openclass_helloworld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {


            if (string.IsNullOrWhiteSpace(id))
                return View("Error");
            else
                ViewData["Nom"] = id;
                return View();           // Equivaut à : return View("Index");
                                         // La méthode View va automatiquement chercher la vue qui placé dans 
                                         // Le repértoire Views dans le dossier DU MEME NOM que le controller ET
                                         // qui s'appelle comme la méthode l'action appellé


                     
        }
    }
}