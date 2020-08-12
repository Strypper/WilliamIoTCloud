using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilliamCloud.ObjectData
{
    public class TrashStatusDTO
    {
        public int TrashId { get; set; }
        public string Model { get; set; }
        public double Percent { get; set; }
        public DateTime SentTime { get; set; }
    }
}
