namespace PraksaHDmp.Data
{
    public class Contact : BaseClass
    {
        public PartnerContactType ContactType { get; set; }
        public int PartnerId { get; set; }
        public string? Name { get; set; }
    }
}
