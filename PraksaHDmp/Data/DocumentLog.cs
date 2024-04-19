namespace PraksaHDmp.Data
{
    public class DocumentLog : BaseClass
    {
        public Device Device { get; set; }
        public DocumentType DocumentType { get; set; }

        public int? ResponsibleEmployeeId { get; set; }
    }
}
