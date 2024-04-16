using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Server : BaseClass
    {
        public Building Building { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }    
        public int BuildingId { get; set; }


    }
}
