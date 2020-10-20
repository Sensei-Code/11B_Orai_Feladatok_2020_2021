using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_FajlOlvasas_Ciklussal
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "services.txt";
            StreamReader sr = new StreamReader(file);
            int sorokszama = 0;
            string[] sortomb = new string[300];
            int index = 0;

            #region Beolvasás
            while (sr.EndOfStream == false)
            {   
                string sor = sr.ReadLine();
                sortomb[index] = sor;                
                index++;
                sorokszama++;

                Console.WriteLine(sor);

                if (sorokszama == 28)
                {
                    sorokszama = 0;
                    Console.Write("Üss egy ENTER-t a folytatáshoz!");
                    Console.ReadLine();
                }
            }

            sr.Close();
            #endregion

            int tcpdb = 0;
            string elem;
            for (int i = 0; i < index; i++)
            {
                elem = sortomb[i];
                if (elem.Contains("tcp") == true)
                    tcpdb++;
            }

            Console.WriteLine("\nAz állományban {0} sor van!",index);
            Console.WriteLine("Az állományban {0} db tcp kifejezés fordul elő!",tcpdb);
            Console.ReadLine();

        }
    }
}
