using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class PartnerContactType : BaseClass
    {
        [Column(TypeName = "nchar(10)")]
        public string Name { get; set; }
    }
}
