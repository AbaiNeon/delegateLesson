﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class ConsoleSender
    {
        public void PrintMessage(object sender, AccountArgs args)
        {
            Console.WriteLine(args.Text + args.Sum);
            Console.ReadLine();
        }
    }
}
