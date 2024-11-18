using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Flower : IFlower
    {
        public int WateringFrequency => 1;
        public string Name => "flower";
    }
}
