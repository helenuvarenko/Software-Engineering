using System;

using Pytomnik.Flowers;
using Pytomnik.Kustarniki;
using Pytomnik.Travy;

namespace Pytomnik
{
    class PolissyaFactory: ICompositionFactory
    {
        private static Random rnd = new Random();

        public ITravy CreateT()
        {
            string[] travy = new string[]
            {
                "Dracaena",//light
                "Lugwort", "Sagebrush" //poor soil
            };
            switch (travy[rnd.Next(0, travy.Length)])
            {

                case "Dracaena": return new Dracaena();
                case "Lugwort": return new Lungwort();
                case "Sagebrush": return new Sagebrush();
                //
                default: throw new Exception("No such classes");

            }
        }

        public IFlowers CreateF()
        {
            string[] flowers = new string[]
            {
                "Rose", "Peony", "Tulip", "Gladiolus",
                "Yarrow", "Violet"
            };

            switch (flowers[rnd.Next(0, flowers.Length)])
            {
                case "Rose": return new Rose();
                case "Peony": return new Peony();
                case "Tulip": return new Tulip();
                case "Gladiolus": return new Gladiolus();
                case "Yarrow": return new Yarrow();
                case "Violet": return new Violet();
                default: throw new Exception("No such classes");
            }
        }

        public IKustarniki CreateK()
        {
            string[] kustar = new string[]
            {
                "Ivy", "Dogrose", "Chlorophytum", "Aspidistra"
            };

            switch (kustar[rnd.Next(0, kustar.Length)])
            {
                case "Chlorophytum": return new Chlorophytum();
                case "Ivy": return new Ivy();
                case "Dogrose": return new Dogrose();
                case "Aspidistra": return new Aspidistra();
                default: throw new Exception("No such classes");
            }
        }

        public override string ToString()
        {
            return "Polissya";
        }

        public string Description()
        {
            return "Your composition is Polissya\n" +
                "It is characterized with shady lightening, rich soil and high humidity";
        }
    }
}
