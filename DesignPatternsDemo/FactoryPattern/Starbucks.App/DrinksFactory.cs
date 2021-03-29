using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.App
{
    public class DrinksFactory
    {
        public static IDrink CreateDrink(string drinkType)
        {
            switch (drinkType)
            {
                case "Mocha":
                    return new Mocha(new string[] { "coffee", "milk", "other stuff" });
                case "Capuccino":
                    return new Capuccino(new string[] { "coffee", "lots of sugar" });
                default:
                    return null;
            }
        }
    }
}
