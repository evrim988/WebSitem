using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSitem.Models.BaseModel
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IsDeleted { get; set; }
        public string IsActive { get; set; }

        [DisplayName("Oluşturulma Tarihi")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Oluşturan Kullanıcı")]
        public string CreatedBy { get; set; }

        [DisplayName("Güncellenme Tarihi")]
        public DateTime LastModifiedOn { get; set; }

        [DisplayName("Güncelleyen Kullanıcı")]
        public string LastModifiedBy { get; set; }
    }
}
