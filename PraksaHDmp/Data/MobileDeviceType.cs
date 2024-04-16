using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class MobileDeviceType : BaseClass
    {
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
    }
}
