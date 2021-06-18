using Microsoft.EntityFrameworkCore;
using SalaDeTeste_EF.API.Model;

namespace SalaDeTeste_EF.API.Data
{
    public class SalaDeTesteDataContext : DbContext
    {
        public SalaDeTesteDataContext(DbContextOptions<SalaDeTesteDataContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
