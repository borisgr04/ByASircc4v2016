//using TestConsoleSupervision.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace TestConsoleSupervision
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Entities db = new Entities()) {
                var q = db.INT_INFOCONT.ToList();
                Console.WriteLine("Hola "+ q.Count());
                Console.ReadKey();
            }
        }
    }
}
