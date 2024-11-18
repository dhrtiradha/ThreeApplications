using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Rose : IFlower
    {
        public int WateringFrequency => 3;
        public string Name => "rose";
    }
}
