using System.ComponentModel;
using WebSitem.Models.BaseModel;

namespace WebSitem.Models.KategoriModel
{
    public class Kategori : BaseEntity
    {
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        public string Description { get; set; }

    }
}
