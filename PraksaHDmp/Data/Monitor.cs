using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Monitor : BaseClass
    {
        public MonitorResolution Resolution { get; set; }
        public MonitorType MonitorType { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? Model { get; set; }
        public bool? InputHDMI { get; set; }
        public bool? InputVGA { get; set; }
        public bool? InputDVI { get; set; }
        public bool? InputDP { get; set; }
        public bool? PivotCapable { get; set; }
        public int? MonitorSizeId { get; set; }
    }
}
