using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Hall
    {
        public int HallId { get; set; }
        public string HallName { get; set; }
        public string HallLocation { get; set; }
        public bool HallAviability { get; set; }
    }
}
