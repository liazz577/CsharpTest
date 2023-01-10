using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Lion : Animal
    {
        public Lion(double weight, string name) : base(weight, name)
        {

        }

        public override void Show()
        {
            base.Show();
        }
        public override void SetMe(int Weight, string Name)
        {
            Name = "Lion";
            Weight = 200;
        }
    }
}
