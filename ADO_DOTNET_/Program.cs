using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DOTNET_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ADO_DOTNET Demo");

            RKdb DB = new RKdb();
            List<RK> rKs = DB.AllRKdb();

            Console.WriteLine("***  ALL TRKDB FROM DATABASE ***");

            foreach (RK rk in rKs)
            {
                Console.WriteLine($"Id :{DB.Id} name : {DB.Name} City : {DB.city} experience : {DB.experience}");
            }
            

            Console.ReadLine();
        }
    }
}
