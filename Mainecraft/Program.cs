using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Console.WriteLine("tree.name= "+tree.Name);
            Iron iron = new Iron();
            Console.WriteLine("iron.name= "+iron.Name);
            Pick pick = new Pick();
            pick.Array[2] = iron;
            Console.WriteLine("pick.Array[2].name= "+ pick.Array[2].Name);
        }
    }
}
