using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.App
{
    public class Memento
    {
        public readonly string status;

        public Memento(string status)
        {
            this.status = status;
        }
    }
}
