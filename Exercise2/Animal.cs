using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Animal
    {
        public Animal(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        public double Weight { get; set; }
        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("Name: " + Name + " " + "Weight: " + Weight);
        }

        public void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}
