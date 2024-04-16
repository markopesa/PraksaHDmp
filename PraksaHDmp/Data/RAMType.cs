using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class RAMType : BaseClass

    {
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
    }
}
