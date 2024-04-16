using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class MonitorResolution : BaseClass
    {
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }    
        public MonitorFormat MonitorFormat { get; set; }
        public int MonitorFormatId { get; set; }
    }
}
