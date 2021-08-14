using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!string.IsNullOrWhiteSpace(args[0]))
            {
                var parameters = args[0].Split(' ');

                var customerId = parameters[1];
                var issuerName = parameters[2];
                var installationPath = parameters[3];
                var registerUpn = parameters[4];

                if (string.IsNullOrWhiteSpace(customerId) ||
                    string.IsNullOrWhiteSpace(issuerName) ||
                    string.IsNullOrWhiteSpace(installationPath) ||
                    string.IsNullOrWhiteSpace(registerUpn))
                {

                    return;
                }


            }

            Console.ReadKey();
        }
    }
}
