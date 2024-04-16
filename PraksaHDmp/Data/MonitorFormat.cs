using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class MonitorFormat : BaseClass 
    {
        [Column(TypeName = "nvarchar(10)")]
        public string Name { get; set; }    
    }
}
