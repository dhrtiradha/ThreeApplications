using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Carnation : IFlower
    {
        public int WateringFrequency => 2;
        public string Name => "carnation";
    }
}
