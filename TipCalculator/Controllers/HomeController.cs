using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model, string commandText)
        {
            if (commandText == "clear")
            {
                model.Amount = 0;
                model.TipPercentage = 0;
                ViewBag.TipResult = null;
            }
            else if (!ModelState.IsValid)
            {
                return View(model);
            }

            decimal tipAmount = model.Amount * model.TipPercentage / 100;
            ViewBag.TipResult = tipAmount;
            return View(model);
        }
    }
}
