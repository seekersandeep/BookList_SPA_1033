using BookList_SPA_1033.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BookList_SPA_1033.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)         
        {
             
        }
        public DbSet<Book> Books { get; set; }
    }
}
