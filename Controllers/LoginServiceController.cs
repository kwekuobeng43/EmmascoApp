using EmmascoTravelsApp1.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmmascoTravelsApp1.Controllers
{
    public class LoginServiceController : Controller
    {

        private readonly AppDbContext context;

        public LoginServiceController(AppDbContext context) {

            this.context = context;
        }


        public IActionResult Index()
        {

            var login = context.LoginServices.ToList();

            return View(login);
        }

        //Add details to Db


        public IActionResult Create()
        {
            return View();
        }
    }
}
