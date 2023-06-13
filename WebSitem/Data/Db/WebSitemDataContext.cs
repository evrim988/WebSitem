using Microsoft.EntityFrameworkCore;
using WebSitem.Models.KategoriModel;
using WebSitem.Models.UrunModel;

namespace WebSitem.Data.Db
{
    public class WebSitemDataContext : DbContext
    {
        public WebSitemDataContext(DbContextOptions<WebSitemDataContext> options) : base(options) 
        {

        }
        public DbSet<Kategori> Kategories { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
    }
}
