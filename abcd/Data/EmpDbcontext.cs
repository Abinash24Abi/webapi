using abcd.Models;
using Microsoft.EntityFrameworkCore;

namespace abcd.Data

{
    public class EmpDbcontext : DbContext
    {
        public EmpDbcontext(DbContextOptions<EmpDbcontext> options) : base(options)
        {
        }

        public DbSet<Emp> tableemp { get; set; }
    }
}
