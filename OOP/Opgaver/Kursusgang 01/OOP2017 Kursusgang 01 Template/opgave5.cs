using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2017_Kursusgang_01_Template
{
    class opgave5
    {
        public void start()
        {
            List<int> LottoNumbers = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 7; i++)
            {
                LottoNumbers.Add(r.Next(0, 100));
            }

            foreach (int item in LottoNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
