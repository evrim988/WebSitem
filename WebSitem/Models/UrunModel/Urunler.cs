using System.ComponentModel;
using WebSitem.Models.BaseModel;
using WebSitem.Models.KategoriModel;

namespace WebSitem.Models.UrunModel
{
    public class Urunler : BaseEntity
    {
        public int KategoriId { get; set; }
        public Kategori Kategoriler { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }

        [DisplayName("Fiyat")]
        public int Price { get; set; }

    }
}
