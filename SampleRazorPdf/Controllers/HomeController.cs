using RazorPDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleRazorPDF.Controllers
{
    public class HomeController : Controller
    {
        public class Person
        {
            public string Name { get; set; }
            public string City { get; set; }

        }
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Pdf(string format)
        {
            // get Person
            var persons = new List<Person>() {
                new Person { Name = "Alfred Einstein"  , City = "Berlin"},
                new Person { Name = "Alfred Nobel" , City = "Karlskoga" },
                new Person { Name = "Niels Bohr" , City = "Copenhagen" }
            };
            if (string.IsNullOrEmpty(format))
            {
                // pass in Model, then View name
                var pdf = new PdfResult(persons, "PdfModelHtml");
                // Add to the view bag
                pdf.ViewBag.Title = "Big scientists";
                return pdf;
            }
            ViewBag.Title = "Big scientists";
            return View("PdfModelHtml", persons);
        }
    }
}
