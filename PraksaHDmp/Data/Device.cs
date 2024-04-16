using System.ComponentModel.DataAnnotations.Schema;

namespace PraksaHDmp.Data
{
    public class Device : BaseClass
    {
        public Building Building { get; set; }
        public DeviceStateNew State { get; set; }
        public DeviceType DeviceType { get; set; }
        public Employee Employee { get; set; }
        public Partner? Partner { get; set; }

        public int InventoryNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? SerialNumber { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? GuaranteeDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? InvoiceNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? ServiceNumber { get; set; }
        [Column(TypeName = "nvarchar(2000)")]
        public string? Note {  get; set; }
        public bool? Decom {  get; set; }
        public int DeviceId { get; set; }
    }
}
