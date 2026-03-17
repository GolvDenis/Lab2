using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task4
{
    public class Virus
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        private Virus(Virus source)
        {
            Name = source.Name;
            Species = source.Species;
            Weight = source.Weight;
            Age = source.Age;
            Children = source.Children.Select(child => (Virus)child.Clone()).ToList();
        }

        public object Clone()
        {
            return new Virus(this);
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public void PrintInfo(string indent = "")
        {
            Console.WriteLine($"{indent}Ім'я: {Name}, Вид: {Species}, Вага: {Weight}, Вік: {Age}");
            if (Children.Any())
            {
                Console.WriteLine($"{indent}Діти:");
                foreach (var child in Children)
                {
                    child.PrintInfo(indent + "  ");
                }
            }
        }

    }

}
