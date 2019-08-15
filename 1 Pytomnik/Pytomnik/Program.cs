using System;

using Pytomnik.Flowers;
using Pytomnik.Kustarniki;
using Pytomnik.Travy;

namespace Pytomnik
{
    class Program
    {
        static void Main(string[] args)
        {
            ICompositionFactory composition;
            ICompositionFactory[] com = new ICompositionFactory[]
            //initializing templates to give a chance to choose one
            {
                 new PolissyaFactory(),
                 new EgyptFactory(),
                 new YourFactory()
            };

            Console.WriteLine("Choose a number to see template or create your own");
            for (int i = 0; i < com.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {com[i].ToString()}");
            }

            int userNum = Int32.Parse(Console.ReadLine());

            switch (userNum)
            {
                case 1:
                    composition = new PolissyaFactory();
                    break;
                case 2:
                    composition = new EgyptFactory();
                    break;
                case 3:
                    composition = new YourFactory();
                    break;
                default: throw new Exception("No such classes");

            }
            IFlowers flowers = composition.CreateF();
            IKustarniki kustarniki = composition.CreateK();
            ITravy travy = composition.CreateT();
            Console.WriteLine(composition.Description());
            Console.WriteLine("Here you have got {0}, {1} and {2}", flowers.ToString(), kustarniki.ToString(), travy.ToString());


           
        }
    }
}
