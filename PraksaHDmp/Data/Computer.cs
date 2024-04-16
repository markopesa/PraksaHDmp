namespace PraksaHDmp.Data
{
    public class Computer : BaseClass
    {
        public new bool? Active { get; set; }
        public ComputerOS? ComputerOS { get; set; }
        public HDDType? HDDType { get; set; }
        public RAMType? RAMType { get; set; }
        public string Model { get; set; }
        public string? CPU { get; set; }
        public string? RAM { get; set; }
        public string HDDModel { get; set; }
        public int HDDCapacity { get; set; }
        public int? NumberOfDiskDrives { get; set; }
        public int HDDSpeedId { get; set; }
        public bool Laptop { get; set; }
        public bool License { get; set; }


        
    }
}
