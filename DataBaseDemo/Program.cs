using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEntities2 proxy = new TestEntities2();
            foreach (Table  p in proxy.Tables)
            {
                Console.WriteLine(p.Sex+p.Name);
            }
        }
    }
}
