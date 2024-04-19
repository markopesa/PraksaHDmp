using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Printer : BaseClass 
    {
        public PrinterType PrinterType { get; set; }    

        [Column(TypeName = "nvarchar(200)")]
        public string Model { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string? IP { get; set; }
         public bool? PortUSB { get; set; }
         public bool? PortLAN { get; set; }
         public bool? PortLPT { get; set; }
         public bool? A3Print { get; set; }
         public bool? Color { get; set; }
    }
}
