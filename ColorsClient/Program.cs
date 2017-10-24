using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "testpipe", PipeDirection.In))
            {
                // Attempt to connect to server.
                Console.Write("connecting to pipe server...");
                pipeClient.Connect();

                // Show connected messages
                Console.WriteLine("Connected");
                using (StreamReader sr = new StreamReader(pipeClient))
                {
                    // Display colors to console.
                    string temp;
                    Console.WriteLine("Received from server: ");

                    while ((temp = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(" {0}", temp);
                    }
                }
            }
            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
