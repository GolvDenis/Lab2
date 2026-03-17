using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task1
{
    public class ManagerCall : SubscriptionCreator
    {
        public override Subscription CreateSubscription(string type)
        {
            if (type == "domestic") return new DomesticSubscription();
            if (type == "educational") return new EducationalSubscription();
            if (type == "premium") return new PremiumSubscription();
            return null;
        }
    }

}
