using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Other : BaseClass
    {
        [Column(TypeName = "nvarchar(200)")]
        public string Model { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Type { get; set; }
    }
}
