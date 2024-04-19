using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Multifunctional : BaseClass
    {
        [Column(TypeName = "nvarchar(200)")]
        public string  Model { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Type {  get; set; }
    }
}
