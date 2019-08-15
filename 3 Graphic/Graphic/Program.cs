 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiCursor cursor = new MultiCursor();
            Pencil pencil = new Pencil();
            Spray spray = new Spray();
            Thickness thickness = new Thickness();

            cursor.SetCommand(0, new PencilCommand(pencil));
            cursor.SetCommand(1, new SprayCommand(spray, 3000));
            cursor.SetCommand(2, new ThicknessCommand(thickness));

            cursor.PressButton(0);
            cursor.PressButton(2);
            cursor.PressButton(2);
            cursor.PressButton(2);

            cursor.PressUndoButton();
            cursor.PressUndoButton();
            cursor.PressUndoButton();
            cursor.PressUndoButton();

            cursor.PressButton(1);
            cursor.PressUndoButton();

            //cursor.SetCommand(new PencilCommand(pencil));
            ////cursor.SetCommand(new ThicknessCommand(thickness));
            //cursor.ItemClick();
            //cursor.UndoClick();

            //Spray spray = new Spray();
            //// 5000 - время заливки фона
            //cursor.SetCommand(new SprayCommand(spray, 5000));
            //cursor.ItemClick();

            Console.Read();
        }
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }



    // Invoker - инициатор
    //class Cursor
    //{
    //    ICommand command;

    //    public Cursor() { }

    //    public void SetCommand(ICommand com)
    //    {
    //        command = com;
    //    }

    //    public void ItemClick()
    //    {
    //        if (command != null)
    //            command.Execute();
    //    }
    //    public void UndoClick()
    //    {
    //        if (command != null)
    //            command.Undo();
    //    }
    //}

    class NoCommand : ICommand
    {
        public void Execute()
        {
        }
        public void Undo()
        {
        }
    }

   
}
