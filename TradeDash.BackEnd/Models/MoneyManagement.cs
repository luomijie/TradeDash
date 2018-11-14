using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace TradeDash.BackEnd.Models
{
    public class MoneyManagement
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal AccountValue { get; set; }

        public decimal ToBuyAll { get; set; }

        public decimal AmountAvIfAllBought { get; set; }
    }
    
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args) =>
            Program.CreateWebHostBuilder(args).Build().Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
    }
}