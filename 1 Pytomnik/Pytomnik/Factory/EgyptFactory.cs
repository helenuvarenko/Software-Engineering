using System;

using Pytomnik.Flowers;
using Pytomnik.Kustarniki;
using Pytomnik.Travy;

namespace Pytomnik
{
    class EgyptFactory: ICompositionFactory
    {
        private static Random rnd = new Random();

        public ITravy CreateT()
        {
            string[] travy = new string[]
            {
                "Cactus",//light
                "Marjoram", "Sagebrush", "Salvia" //poor soil
            };
            switch (travy[rnd.Next(0, travy.Length)])
            {

                case "Cactus": return new Cactus();
                case "Marjoram": return new Marjoram();
                case "Sagebrush": return new Sagebrush();
                case "Salvia": return new Salvia();
                //
                default: throw new Exception("No such classes");

            }
        }

        public IFlowers CreateF()
        {
            string[] flowers = new string[]
            {
                "Rose", "Peony",
                "Yarrow"
            };

            switch (flowers[rnd.Next(0, flowers.Length)])
            {
                case "Rose": return new Rose();
                case "Peony": return new Peony();
                case "Yarrow": return new Yarrow();
                default: throw new Exception("No such classes");
            }
        }

        public IKustarniki CreateK()
        {
            string[] kustar = new string[]
            {
                "Aloe", "Ivy", "Sansevieria", "Gaillardia"
            };

            switch (kustar[rnd.Next(0, kustar.Length)])
            {
                case "Aloe": return new Aloe();
                case "Ivy": return new Ivy();
                case "Sansevieria": return new Sansevieria();
                case "Gaillardia": return new Gaillardia();
                case "Thuja": return new Thuja();
                default: throw new Exception("No such classes");
            }
        }

        public override string ToString()
        {
            return "Egypt";
        }

        public string Description()
        {
            return "Your composition is Egypt\n" +
                "It is characterized with bright lightening, sandy soil and high tempetature";
        }
    }
}
