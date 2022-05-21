using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int brPens = int.Parse(Console.ReadLine());
            int brMarkers = int.Parse(Console.ReadLine());
            int prep = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double pacPens = 5.8;
            double pacMarkers = 7.2;
            double prepLit = 1.2;

            double sumPens = brPens * pacPens;
            double sumMarkers = brMarkers * pacMarkers;
            double sumPrep = prep * prepLit;
            double realPerc = percent / 100;

            double sum = sumPens + sumMarkers + sumPrep;
            double sumPercent = sum - (sum * realPerc);

            Console.WriteLine(sumPercent);

        }
    }
}