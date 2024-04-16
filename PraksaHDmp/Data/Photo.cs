using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Photo : BaseClass
    {
        public EntityType EntityType { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FileName { get; set; }
        public int EntityId { get; set; }

    }
}
