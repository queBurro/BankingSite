using System.Web.Mvc;
using BankingSite.Models;

namespace BankingSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //Action method. Index is called by convention 
        {
            ViewBag.Message = "Apply today for our award winning personal loans.";

            // Hard-coded rates for demo purposes
            var rates = new InterestRates
                        {
                            CreditCardRate = 22.33m,
                            LoanRate = 9.24m,
                            TermDepositRate = 5.2m
                        };

            return View(rates);
        } 
        
        public string Something()
        {
            return "Something says hello";
        }

        public ActionResult Contact()
        {
            return Redirect("http://pluralsight.com");
        }
    }
}