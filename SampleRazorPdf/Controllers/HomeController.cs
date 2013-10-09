using RazorPDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleRazorPdf.Controllers
{
    public class HomeController : Controller
    {
        public class Person
        {
            public string Name { get; set; }

            public string City { get; set; }
            public int Age { get; set; }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Pdf()
        {
            // get Person
            var persons = new List<Person>() {
                new Person { Name = "Alfred Einstein"  , City = "Berlin"},
                new Person { Name = "Alfred Nobel" , City = "Karlskoga" },
                new Person { Name = "Niels Bohr" , City = "Copenhagen" }
            };
            // pass in Model, then View name
            var pdf = new PdfResult(persons,"PdfModelHtml");
            // Add to the view bag
            pdf.ViewBag.Title = "Big scientists";

            return pdf;
        }
    }
}