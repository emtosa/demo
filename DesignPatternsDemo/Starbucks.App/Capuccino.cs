using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.App
{
    public class Capuccino : IDrink
    {
        public Capuccino(string[] ingredients)
        {
        }

        public void Making()
        {
            throw new NotImplementedException();
        }

        public int Price()
        {
            return 5;
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
