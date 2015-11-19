using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMoq
{
    public class OneClass : AbstractClass
    {
        protected override void OneProtectedMethod()
        {
            Console.WriteLine("Hello");
        }

        public void DoMethod()
        {
            OneProtectedMethod();
        }
    }

    public abstract class AbstractClass
    {
        protected abstract void OneProtectedMethod();
    }
}
