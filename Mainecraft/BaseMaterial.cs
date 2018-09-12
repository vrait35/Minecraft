using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainecraft
{
    public abstract class BaseMaterial
    {
        public string Name { get; set; }
        public BaseMaterial()
        {
            Name = GetType().Name;
        }
    }
}
