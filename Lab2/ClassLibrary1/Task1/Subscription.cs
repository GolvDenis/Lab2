using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task1
{
    public abstract class Subscription
    {
        public double MonthlyFee;
        public int MinPeriod;
        public List<string> Channels = new List<string>();

        public void ShowInfo()
        {
            Console.WriteLine($"Price: {MonthlyFee}");
            Console.WriteLine($"Min period: {MinPeriod}");
            Console.WriteLine("Channels: " + string.Join(", ", Channels));
            Console.WriteLine();
        }
    }
}
