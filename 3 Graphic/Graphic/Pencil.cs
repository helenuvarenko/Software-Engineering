using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    // Receiver - Получатель
    class Pencil
    {
        public void PickPencil()
        {
            Console.WriteLine("You are using a pencil!");

        }

        public void UnPickPencil()
        {
            Console.WriteLine("You have just put the pencil aside...");
        }
    }

    class PencilCommand : ICommand
    {
        Pencil pencil;
        public PencilCommand(Pencil pencilSet)
        {
            pencil = pencilSet;
        }
        public void Execute()
        {
            pencil.PickPencil();
        }
        public void Undo()
        {
            pencil.UnPickPencil();
        }
    }
}
