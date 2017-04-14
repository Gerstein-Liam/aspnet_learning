using openclass_helloworld.Models;          // il faut l'inclure , ce n'est pas dis le cours
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
                ViewData["Nom"] = id;    // On peut aussi utiliser ViewBag.Nom (type dynamic)
                return View();           // Equivaut à : return View("Index");
                                         // La méthode View va automatiquement chercher la vue qui placé dans 
                                         // Le repértoire Views dans le dossier DU MEME NOM que le controller ET
                                         // qui s'appelle comme la méthode l'action appellé


                     
        }


        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.ObtenirListeClients();
            return View();
        }

        public ActionResult ChercheClient(string id)
        {
            ViewData["Nom"] = id;
            Clients clients = new Clients();
            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
            {
                ViewData["Age"] = client.Age;
                return View("Trouve");
            }
            return View("NonTrouve");
        }



    }
}