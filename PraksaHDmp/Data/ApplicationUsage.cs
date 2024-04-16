using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class ApplicationUsage : BaseClass
    {
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool Active { get; set; } = true;
    }
}
