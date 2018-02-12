using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ServiceReference1.Service1Client())
            {
                var liste = client.GetMyNanme();
                var list2 = client.GetMyEmail();

                Console.WriteLine(liste);
                Console.WriteLine(list2);
                
            }

            Console.ReadKey();
        }
    }
}
