using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CodeFirst
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Students { get; set; }

        Task<int> SaveChanges();
    }
}