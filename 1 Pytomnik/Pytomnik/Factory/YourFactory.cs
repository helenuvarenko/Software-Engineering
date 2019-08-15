using System;
using Pytomnik.Flowers;
using Pytomnik.Kustarniki;
using Pytomnik.Travy;

namespace Pytomnik
{
    class YourFactory: ICompositionFactory
    {
        private static Random rnd = new Random();

        public ITravy CreateT()
        {
            string[] travy = new string[]
            {
                "Cactus","Dracaena", "Lungwort", //light
                "Marjoram", "Sagebrush", "Salvia" //poor soil
            };
            switch (travy[rnd.Next(0, travy.Length)])
            {

                case "Cactus": return new Cactus();
                case "Marjoram": return new Marjoram();
                case "Sagebrush": return new Sagebrush();
                case "Salvia": return new Salvia();
                case "Dracaena": return new Dracaena();
                case "Lungwort": return new Lungwort();
                //
                default: throw new Exception("No such classes");

            }
        }

        public IFlowers CreateF()
        {
            string[] flowers = new string[]
           {
                "Rose", "Peony",
                "Yarrow", "Gladiolus", "Tulip", "Violet"
           };

            switch (flowers[rnd.Next(0, flowers.Length)])
            {
                case "Rose": return new Rose();
                case "Peony": return new Peony();
                case "Yarrow": return new Yarrow();
                case "Gladiolus": return new Gladiolus();
                case "Tulip": return new Tulip();
                case "Violet": return new Violet();
                default: throw new Exception("No such classes");
            }
        }

        public IKustarniki CreateK()
        {
            string[] kustar = new string[]
           {
                "Aloe", "Ivy", "Sansevieria", "Gaillardia", "Thuja",
                "Aspidistra", "Chlorophytum", "Dogrose"
           };

            switch (kustar[rnd.Next(0, kustar.Length)])
            {
                case "Aloe": return new Aloe();
                case "Ivy": return new Ivy();
                case "Sansevieria": return new Sansevieria();
                case "Gaillardia": return new Gaillardia();
                case "Thuja": return new Thuja();
                case "Aspidistra": return new Aspidistra();
                case "Chlorophytum": return new Chlorophytum();
                case "Dogrose": return new Dogrose();
                default: throw new Exception("No such classes");
            }

        }

        public override string ToString()
        {
            return "Your Composition";
        }

        public string Description()
        {
            return "You have chosen to create a composition yourself, good luck\n" +
                "Characterize it as you wish, it is all up to you";
        }
    }
}
