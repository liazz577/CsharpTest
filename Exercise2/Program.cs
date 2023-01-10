using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Tiger(100, "tiger");
            a.Show();
            a = new Lion(200, "lion");
            a.Show();
        }
    }
}
