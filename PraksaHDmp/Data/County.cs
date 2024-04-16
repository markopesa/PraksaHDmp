using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class County : BaseClass
    {
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
    }
}
