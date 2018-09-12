using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainecraft
{
    public class Pick
    {
        public BaseMaterial[] Array { get; set; }
        public Pick() : base() { Array = new BaseMaterial[5]; }

    }
}
