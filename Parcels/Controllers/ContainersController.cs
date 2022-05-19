using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ContainersController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Container> containers = Container.GetAllContainers();
            return View(containers);
        }
       [HttpGet("/parcels/new")]
       public ActionResult New()
       {
           return View();
       }

       [HttpPost("/parcels")] 
       public ActionResult Parcel(string name , string weight  ,string height , string length , string breadth)
       {
           Container con = new Container(name , float.Parse(length) , float.Parse(breadth) , float.Parse(length) , float.Parse(weight));
           return RedirectToAction("Index");
       }

       [HttpGet("/parcels/ship")]
       public ActionResult Ship()
       {
           return View();
       }
    }
}