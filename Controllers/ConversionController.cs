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
      if (model.ConversionType == "meters-to-feet")
      {
            model.ConvertedValue = model.ValueToConvert * 3.28084m;
            return View(model);
      }
        
       else if (model.ConversionType == "feet-to-meters")
        {
            model.ConvertedValue = model.ValueToConvert * 0.3048m;
            return View(model);
            
        } 

       else if (model.ConversionType == "pounds-to-ounces")
        {
            model.ConvertedValue = model.ValueToConvert * 16m;
            return View(model);
            
        }

        
       else if (model.ConversionType == "ounces-to-pounds")
        {
            model.ConvertedValue = model.ValueToConvert * 0.0625m;
            return View(model);
            
        }

//Temp Conversions start here
              else if (model.ConversionType == "f-to-c")
        {
            model.ConvertedValue = (model.ValueToConvert-32) * (5m/9m);
            return View(model);
            
        }

                      else if (model.ConversionType == "c-to-f")
        {
            model.ConvertedValue = model.ValueToConvert * (1.8m) + 32;
            return View(model);
            
        }


        else 
        {
            Console.WriteLine("Invalid Option");
            return View(model);
            
        }
        }
    }

    }


