﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StringModify
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

            WriteLine("Insert() : '{0}'", "Happy Friday".Insert(5, " Sunny"));
            WriteLine("Remove() : '{0}'", "I Don't Love you.".Remove(2, 6));

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart(): '{0}'", " No Spaces ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", " No Sapces ".TrimEnd());
        }
    }
}
