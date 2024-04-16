using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class MonitorSize : BaseClass
    {
        [Column(TypeName = "varchar(5)")]
        public string Size { get; set; }
    }
}
