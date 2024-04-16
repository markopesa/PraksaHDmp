namespace PraksaHDmp.Data
{
    public class Address : BaseClass

    {
        
        public County County { get; set; }
        public Partner Partner { get; set; }
        public string? Settlement { get; set; }
        public int PostalNumber { get; set; }
        public string AddressLine {  get; set; }

    }
}
