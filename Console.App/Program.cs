using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TC.Test.Build.Library.A;

namespace TC.Test.Build.Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            TC.Test.Build.Library.A.Bar bar = new TC.Test.Build.Library.A.Bar();

            bar.Name = "Babar";

            System.Console.WriteLine(bar.Name);
        }
    }
}
