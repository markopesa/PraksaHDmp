using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Scanner : BaseClass
    {
        [Column(TypeName = "nvarchar(20)")]
        public string Model { get; set; }
        public bool? ScanA3 { get; set; }
    }
}
