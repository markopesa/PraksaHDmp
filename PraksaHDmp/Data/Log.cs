using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Log : BaseClass
    {
        public Application Application { get; set; }
        public int ApplicationId { get; set; }
        [Column(TypeName = "nvarchar(2000)")]
        public string? Name { get; set; }

    }
}
