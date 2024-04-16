﻿namespace PraksaHDmp.Data
{
    public class MonitorResolution : BaseClass
    {
        public User UserCreated { get; set; }
        public User UserModified { get; set; }
        public string Name { get; set; }    
        public MonitorFormat MonitorFormat { get; set; }
        public int MonitorFormatId { get; set; }
    }
}
