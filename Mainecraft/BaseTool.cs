using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainecraft
{
    public abstract class BaseTool
    {
        public string Name { get; set; }
        public BaseTool() { Name = GetType().Name; }
    }
}
