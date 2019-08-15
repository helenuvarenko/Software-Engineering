using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{

    class Spray
    {
        public void StartSpraying(int time)
        {
            Console.WriteLine("You are spraying your area with spray");
            // имитация работы с помощью асинхронного метода Task.Delay
            Task.Delay(time).GetAwaiter().GetResult();
        }

        public void StopSpraying()
        {
            Console.WriteLine("You have finished your spraying!");
        }
    }
    class SprayCommand : ICommand
    {
        Spray spray;
        int time;
        public SprayCommand(Spray s, int t)
        {
            spray = s;
            time = t;
        }
        public void Execute()
        {
            spray.StartSpraying(time);
            //spray.StopSpraying();
        }

        public void Undo()
        {
            spray.StopSpraying();
        }
    }

}
