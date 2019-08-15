using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{

    class Thickness
    {
        public const int off = 1;
        public const int max = 20;
        private int current;

        public Thickness()
        {
            current = off;
        }

        public void Raise()
        {
            if (current < max)
                current++;
            Console.WriteLine("Current thickness mode is {0}", current);
        }
        public void Drop()
        {
            if (current > off)
                current--;
            Console.WriteLine("Current thickness mode is {0}", current);
        }
    }

    class ThicknessCommand : ICommand
    {
        Thickness thickness;
        public ThicknessCommand(Thickness t)
        {
            thickness = t;
        }
        public void Execute()
        {
            thickness.Raise();
        }

        public void Undo()
        {
            thickness.Drop();
        }
    }

}
