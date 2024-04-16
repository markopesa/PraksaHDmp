using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Location : BaseClass
    {
        public Department Department { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }    
        public int DepartmentId { get; set; }
    }
}
