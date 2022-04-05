using Microsoft.EntityFrameworkCore;

namespace WebAppApi.Models
{
    public class MahasiswaContext : DbContext
    {
        public MahasiswaContext(DbContextOptions<MahasiswaContext> options) : base(options)
        {
        }

        public DbSet<Mahasiswa> Mahasiswas { get; set; }
    }
}
