 
using System.Collections.Generic;
 
namespace Records_Manager
{
    public class Disk
    {
        public string Brand { get; set; }
        public int Capacity { get; set; }
        public int Enumeration { get; set; }
        public List<Record> Data { get; set; }
        public Disk(string brand, int capacity, int enumeration, List<Record> data)
        {
            Brand = brand;
            Capacity = capacity;
            Enumeration = enumeration;
            Data = data;
        }
    }
}
