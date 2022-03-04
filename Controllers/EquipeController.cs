using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult: é apropriado para quando temos diversos
        //tipos possíveis

        EquipeController equipeModel = new equipe();


        //ActionResult representa os status de HTTP
        public IActionResult Index()
        {
            ViewBag.equipes = equipeModel.LerEquipes();


            return View();
        }

        private dynamic LerEquipes()
        {
            throw new NotImplementedException();
        }

        public static implicit operator EquipeController(equipe v)
        {
            throw new NotImplementedException();
        }
    }
}
