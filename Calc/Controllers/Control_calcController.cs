using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calc.Controllers
{
    public class Control_calcController : Controller
    {
        // GET: Control_calc
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult total(double value1, double value2, double value3, double value4,  string calc)
        {
            double timeC = 0;
            double feetC = 0;
            double total = 0;
            switch(calc)
            {
                case "Burn Rate":
                    feetC = value1 + (value2 / 12);
                    timeC = (value3 * 60) + value4;
                    total = timeC / feetC;
                    break;
                
                default:
                    total = 0;
                    break;
            }
            return Content(total + " Seconds Per Foot");
        }
    }
}