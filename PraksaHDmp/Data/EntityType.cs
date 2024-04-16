using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class EntityType : BaseClass
    {
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
    }
}
