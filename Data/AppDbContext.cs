using EmmascoTravelsApp1.Models;
using Microsoft.EntityFrameworkCore;


namespace EmmascoTravelsApp1.Data
{
    public class AppDbContext : DbContext
    {
        private object customerService;

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }

            public DbSet<LoginService> LoginServices { get; set; }
        public object LoginService { get; internal set; }

        public DbSet<RegisterService> RegisterServices { get; set; }
        public object RegisterService { get; internal set; }

        public DbSet<CustomerService> CustomerServices { get; set; }
        public object CustomerService { get; internal set; }
    }
}
