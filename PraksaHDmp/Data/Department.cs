using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Department : BaseClass
    {
        [Column(TypeName = "nvarchar(500)")]
        public string Name { get; set; }

        
    }
}
