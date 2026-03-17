using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task5
{
    public class Character
    {
        public int Height;
        public string Body;
        public string Hair;
        public string Eyes;
        public List<string> Clothes = new List<string>();
        public List<string> Items = new List<string>();

        public void Show()
        {
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Hair: {Hair}");
            Console.WriteLine($"Eyes: {Eyes}");
            Console.WriteLine("Clothes: " + string.Join(", ", Clothes));
            Console.WriteLine("Items: " + string.Join(", ", Items));
            Console.WriteLine();
        }
    }
}
