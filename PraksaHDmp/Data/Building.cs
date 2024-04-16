using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Building : BaseClass
    {

        public Location Location { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        public int LocationId { get; set; } 
    }
}
