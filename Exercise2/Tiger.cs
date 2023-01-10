using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Tiger: Animal
    {
        public Tiger() { }

        public override void Show()
        {
            base.Show();
        }
        public override void SetMe(int weight, string name)
        {
            Name = "Tiger";
            Weight = 100;
        }
    }
}
