using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroFirstTest
{
    public class SomeFunctions
    {
        // make a function that can be tested later by a test class (not a framework. for now)
        public string ReturnsBanana(bool boolVal)
        {
            if(boolVal is true)
            {
                return "BAnana";
            }
            else
            {
                return "Almonds";
            }
        }
    }
}
