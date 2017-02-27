using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5
{
    class MyDirectory
    {
        public void PrintDirectory()
        {
            Console.Write("Enter Path to Directory:");
            string path = Console.ReadLine();

            DirectoryInfo di = new DirectoryInfo(path);
            try
            {
                if (di.Exists)
                {
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        Console.WriteLine(dir.Name);
                        foreach (FileInfo file in dir.GetFiles())
                        {
                            Console.WriteLine("  " + file.Name + " | " + file.Length + " Bytes");
                        }
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That path dosnt exists");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());

            }
        }
    }
}
