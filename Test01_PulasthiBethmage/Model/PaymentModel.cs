using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01_PulasthiBethmage.Model
{
    class PaymentModel:IPaymentModel
    {
        // Adding Text to Label.
        public List<String> setInfo()
        {
            List<String> l = new List<string>();
            l.Add("First Name:");
            l.Add("Last Name:");
            l.Add("Contact Number:");
            l.Add("Amount Paid:");
            l.Add("0.0");
            return l;
        }
    }
}
