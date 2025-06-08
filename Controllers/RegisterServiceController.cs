using EmmascoTravelsApp1.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmmascoTravelsApp1.Controllers
{
    public class RegisterServiceController : Controller
    {

        private readonly AppDbContext context;

        public RegisterServiceController(AppDbContext context)
        {

            this.context = context;
        }


        public IActionResult Index()
        {

            var register = context.RegisterServices.ToList();

            return View(register);
        }

        //Add details to Db


        public IActionResult Create()
        {
            return View();
        }
    }
}

