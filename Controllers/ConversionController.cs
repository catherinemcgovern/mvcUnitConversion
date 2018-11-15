using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UConverter.Models;

namespace UConverter.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            string message = "this is the message";
            ViewData["Message"] = message;
            return View();
        }
   public IActionResult Converter()
        {
            string message = "this is the message";
            ViewData["Message"] = message;
            return View();
        }

       [HttpPost]
       public IActionResult DoConversion(ConverterViewModel model)
        {
       // model.ConvertedValue = model.ValueToConvert * model.ValueToConvert;
            model.ConvertedValue = model.ValueToConvert * 3.28084m;
            return View(model);
        }




    }
}
