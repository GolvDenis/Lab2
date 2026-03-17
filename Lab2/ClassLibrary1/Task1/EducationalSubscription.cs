using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task1
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            MonthlyFee = 5;
            MinPeriod = 6;
            Channels.Add("Discovery");
            Channels.Add("Science");
        }
    }
}
