using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helsinki
{
    public class Helyezes
    {
        public int eredmeny;
        public int letszam;
        public string sportag;
        public string versenyszam;
    }



    class Program
    {
        static void Main(string[] args)
        {
            
            Helyezes[] helyezestomb = new Helyezes[200];
            string file = "helsinki.txt";
            string sor;
            int index = 0;
            string[] sortomb;
            StreamReader sr = new StreamReader(file);

            while (sr.EndOfStream==false)
            {
                sor = sr.ReadLine();
                sortomb = sor.Split(' ');

                Helyezes h = new Helyezes();
                h.eredmeny = int.Parse(sortomb[0]);
                h.letszam = int.Parse(sortomb[1]);
                h.sportag = sortomb[2];
                h.versenyszam = sortomb[3];

                helyezestomb[index] = h;
                index++;

            }
            sr.Close();


            Console.WriteLine("3. feladat:");
            Console.WriteLine("Pontszerző helyezések száma: {0}",index);

            int arany = 0;
            int ezust = 0;
            int bronz = 0;
            int negyedik = 0;
            int otodik = 0;
            int hatodik = 0;

            for (int i = 0; i < index; i++)
            {
                if (helyezestomb[i].eredmeny == 1) arany++;
                if (helyezestomb[i].eredmeny == 2) ezust++;
                if (helyezestomb[i].eredmeny == 3) bronz++;
                if (helyezestomb[i].eredmeny == 4) negyedik++;
                if (helyezestomb[i].eredmeny == 5) otodik++;
                if (helyezestomb[i].eredmeny == 6) hatodik++;

            }

            Console.WriteLine("4. feladat:");
            Console.WriteLine("Arany: {0}",arany);
            Console.WriteLine("Ezüst: {0}", ezust);
            Console.WriteLine("Bronz: {0}", bronz);
            Console.WriteLine("Összese: {0}", arany+ezust+bronz);

            int pontszam = (arany * 7) + (ezust * 5) + (bronz * 4) + (negyedik * 3) + (otodik * 2) + hatodik;
            Console.WriteLine("5. feladat:\nOlimpiai pontok száma: {0}",pontszam);

            int uszaserem = 0;
            int tornaerem = 0;
            for (int i = 0; i < index; i++)
            {
                if (helyezestomb[i].sportag == "uszas")
                {
                    if (helyezestomb[i].eredmeny >= 1 && helyezestomb[i].eredmeny <= 3)
                        uszaserem++;
                }

                if (helyezestomb[i].sportag == "torna")
                {
                    if (helyezestomb[i].eredmeny >= 1 && helyezestomb[i].eredmeny <= 3)
                        tornaerem++;
                }
            }
            Console.WriteLine("6. feladat: ");

            if (tornaerem > uszaserem)
                Console.WriteLine("Torna sportágban szereztek több érmet");
            else
            {
                if (tornaerem==uszaserem)
                    Console.WriteLine("Egyenlő volt az érmek száma");              
                else
                    Console.WriteLine("Uszás sportágban szereztek több érmet");
            }
            string file2 = "helsinki2.txt";
            StreamWriter sw = new StreamWriter(file2);
            string helyessportag;
            for (int i = 0; i < index; i++)
            {
                switch (helyezestomb[i].eredmeny)
                {
                   case 1:                  
                         pontszam = 7;
                         break;
                    case 2:
                        pontszam = 5;
                        break;
                    case 3:
                        pontszam = 4;
                        break;
                    case 4:
                        pontszam = 3;
                        break;
                    case 5:
                        pontszam = 2;
                        break;
                    case 6:
                        pontszam = 1;
                        break;                     
                }

                if (helyezestomb[i].sportag == "kajakkenu")
                    helyessportag = "kajak-kenu";
                else
                    helyessportag = helyezestomb[i].sportag;

                sor = helyezestomb[i].eredmeny + " " + helyezestomb[i].letszam + " " + 
                    pontszam + " " + helyessportag + " " + helyezestomb[i].versenyszam;

                sw.WriteLine(sor);

            }
            sw.Close();

            int letszammax = 0;
            int maxindex = 0;

            for (int i = 0; i < index; i++)
            {
                if (helyezestomb[i].letszam > letszammax)
                {
                    letszammax = helyezestomb[i].letszam;
                    maxindex = i;
                }
            }

            Console.WriteLine("8. feladat:");
            Console.WriteLine("Helyezes: {0}",helyezestomb[maxindex].eredmeny);
            Console.WriteLine("Sportág: {0}", helyezestomb[maxindex].sportag);
            Console.WriteLine("Versenyszám: {0}", helyezestomb[maxindex].versenyszam);
            Console.WriteLine("Sportolók száma: {0}", helyezestomb[maxindex].letszam);



            Console.ReadLine();


        }
    }
}
