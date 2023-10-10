using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{       
        class Bird : Animal
        {
            public string FeatherColor { get; set; }
            public bool CanFly { get; set; }
            public int Wingspan { get; set; }
            public bool HasBeak { get; set; }
        }          
}
