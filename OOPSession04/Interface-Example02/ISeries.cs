using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession04.Interface_Example02
{
    internal interface ISeries
    {
        //singature for property
        public int Current { get; set; }
        
        //signature for method
        public void GetNext();

        public void Reset()
        {
            Current = 0;    
        }
            

    }
}
