using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploCSharp.Utils
{
    public static class Console
    {
        public static string ReadLine()
        {
            var input = System.Console.ReadLine();
       
            return string.IsNullOrEmpty(input) ? string.Empty : input;
        }
    }
}