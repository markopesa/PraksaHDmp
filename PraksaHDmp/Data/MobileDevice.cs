using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class MobileDevice : BaseClass
    {
        public MobileDeviceType MobileDeviceType { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Model { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string? ScreenSize { get; set; }
        public int? InternalMemory {  get; set; }   
        public int? ExternalMemory {  get; set; }   
    }
}
