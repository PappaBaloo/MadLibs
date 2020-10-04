using System;

namespace MadLibs010101
{
    class Program
    {
        static void Main(string[] args)
        {
            string LargeRegion;
            string CountryInRegion;
            string PositionOfPower;
            string Celebrity;
            string CaoCaoChina;

            Console.Write("Enter a large region of the world: ");
            LargeRegion = Console.ReadLine();

            Console.Write("Enter a country in that region: ");
            CountryInRegion = Console.ReadLine();

            Console.Write("Enter a position of power: ");
            PositionOfPower = Console.ReadLine();

            Console.Write("Enter a celebrity name: ");
            Celebrity = Console.ReadLine();

            CaoCaoChina = "During the turmoil of " + LargeRegion + " , " + Celebrity + " was able to secure most of " + CountryInRegion + " - the most populated and developed part of " + CountryInRegion + ". " + Celebrity + " was also very successful in restoring public order and rebuilding the economy as the " + PositionOfPower + "";
            Console.WriteLine(CaoCaoChina);

            Console.ReadKey();
        }
    }
}
