using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBug
{
    public class SpaceShipParameters : IParameter
    {
        public string Text { get; set; }
        public int Int { get; set; }
        public double Point { get; set; }
    }
}
