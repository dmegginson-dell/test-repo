using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TC.Test.Build.Library.A
{
    public class Foo
    {
        public string Name { get; set; }

        public DateTime CurrentDateTime 
        { 
            get { return DateTime.Now; }
        }
    }
}
