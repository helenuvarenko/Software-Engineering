using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    class MultiCursor
    {
        ICommand[] buttons;
        Stack<ICommand> commandsHistory;

        public MultiCursor()
        {
            buttons = new ICommand[3];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new NoCommand();
            }
            commandsHistory = new Stack<ICommand>();
        }

        public void SetCommand(int number, ICommand com)
        {
            buttons[number] = com;
        }

        public void PressButton(int number)
        {
            buttons[number].Execute();
            // добавляем выполненную команду в историю команд
            commandsHistory.Push(buttons[number]);
        }
        public void PressUndoButton()
        {
            if (commandsHistory.Count > 0)
            {
                ICommand undoCommand = commandsHistory.Pop();
                undoCommand.Undo();
            }
        }

    }
}
