using Microsoft.EntityFrameworkCore;
namespace Cozma_Laurentiu_Lab6.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        
        }

        public DbSet<Expense> Expense { get; set; }
    }
}
