using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession04.Interface_Example03
{
    internal class Airplane : Vichle, IMovable, IFlyable
    {
        public void Backward()
        {
            Console.WriteLine("Backward implicitly");
        }

        public void Forward()
        {
             Console.WriteLine("Forward implicitly");
        }

        void IMovable.Backward()
        {
            Console.WriteLine("Backward Explicitly");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Forward Explicitly");
        }
    }
}
