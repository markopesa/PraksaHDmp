using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class HDDType : BaseClass
    {
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }    
    }
}
