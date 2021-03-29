using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.App
{
    public interface IDrink
    {
        int Price();
        int Size();

        void Making();
    }
}
