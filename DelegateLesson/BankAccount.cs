using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{    
    public class BankAccount
    {
        public delegate void AccountOperationsHandler(object sender, AccountArgs args);
        public event AccountOperationsHandler OperationHandler;

        public double Sum { get; private set; }        

        public void Add (int sum)
        {
            Sum += sum;
            if (OperationHandler != null)
            {
                OperationHandler(this, new AccountArgs("Вы добавили ", sum));
            }
        }

        public void Withdraw (int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                if (OperationHandler != null)
                {
                    OperationHandler(this, new AccountArgs("Вы сняли ", sum));
                }
            }

            if (OperationHandler != null)
            {
                OperationHandler(this, new AccountArgs("Недостаточно средств", 0));
            }
        }
    }

}
