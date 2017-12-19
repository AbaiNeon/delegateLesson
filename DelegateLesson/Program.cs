using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Add(100);
            account.OperationHandler += new ConsoleSender().PrintMessage;
            account.OperationHandler += new SmsSender().SendMessage;
        }
    }
}

