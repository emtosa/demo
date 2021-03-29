using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.App
{
    public class Mocha : IDrink
    {
        public Mocha(string[] ingredients)
        {
        }

        public void Making()
        {
            throw new NotImplementedException();
        }

        public int Price()
        {
            return 3;
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
