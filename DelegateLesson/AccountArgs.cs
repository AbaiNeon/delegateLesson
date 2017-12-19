using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class AccountArgs
    {
        public string Text { get; set; }
        public double Sum { get; set; }

        public AccountArgs(string text, double sum)
        {
            Text = text;
            Sum = sum;
        }
    }
}
