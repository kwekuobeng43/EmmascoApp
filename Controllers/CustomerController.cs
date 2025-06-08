using EmmascoTravelsApp1.Data;
using EmmascoTravelsApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmmascoTravelsApp1.Controllers
{
    public class CustomerController : Controller
    {


        private readonly AppDbContext context;
        private readonly IWebHostEnvironment environment;

        public CustomerController (AppDbContext context, IWebHostEnvironment environment)
        {
            this.context = context;
            this.environment = environment;
        }
        public IActionResult Index()
        {

            var customer = context.CustomerServices.ToList();

            return View(customer);
        }


        public IActionResult Create()
        {
            return View();
        }

            [HttpPost]
            public IActionResult Create(CustomerServiceDt customerServiceDt)
            {
                if (!ModelState.IsValid)
                {
                    return View(customerServiceDt);
                }

                // Save data to database
                CustomerService customerService = new CustomerService()
                {
                    FirstName = customerServiceDt.FirstName,
                    LastName = customerServiceDt.LastName,
                    Email = customerServiceDt.Email,
                    Phone = customerServiceDt.Phone,
                    Address = customerServiceDt.Address
                };

                context.CustomerServices.Add(customerService);
                context.SaveChanges();

                return RedirectToAction("Index", "Customer");
            }

        }
        
        }

   


