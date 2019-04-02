using Farm_Walker.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Walker
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter comma separed commands");
            string inCommands = Console.ReadLine();
            var comms = inCommands.Split(',');
            
          // string[] comms = new string[] { "N4", "E2", "S2", "W4" };
           var cmd = new Commander(comms.ToList());
           cmd.Run();
           Console.ReadLine();
        }
    }


   

    
}
