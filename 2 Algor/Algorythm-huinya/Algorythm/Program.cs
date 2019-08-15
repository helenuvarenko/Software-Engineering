using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm
{
    class Program
    {
        static void Main(string[] args)
        {
            Block bl1 = new Block("Console.WriteLine('Welcome to your way!')");
            Block bl2 = new Block("string way = 'straight' ");
            Block bl3 = new Block("Console.WriteLine('You go ' + way)");

            Branch bl4 = new Branch("Console.WriteLine('Where go next? left or right?') ");           

            Block bl41 = new Block("string answer = 'Console.Readline()' ");
            Block bl42 = new Block("string newWay = answer");
            Block bl43 = new Block("Console.WriteLine('You have changed your way on right')");
            Block bl44 = new Block("Console.WriteLine('You have changed your way on left')");

            Elements el = new Elements("Main");

            el.Add(bl1);
            el.Add(bl2);
            el.Add(bl3);
            el.Add(bl4);
            el.Execute();
 


            Console.WriteLine("left or right?");
            string answer = Console.ReadLine();
            if (answer == "right")
            {
                bl4.Add(bl41, answer);
                bl4.Add(bl42, answer);
                bl4.Add(bl43, answer);
            }
            if (answer == "left")
            {
                bl4.Add(bl41, answer);
                bl4.Add(bl42, answer);
                bl4.Add(bl44, answer);
            }

            el.Execute();

            Console.ReadKey();
        }
    }

    public interface IElement
    {
        string Action();
        void Execute();

    }


    public class Elements : IElement
    {
        public string Name { get; private set; }

        List<IElement> AllElements { get; set; }

        public Elements(string name)
        {
            Name = name;
            AllElements = new List<IElement>();
        }

        public void Add(IElement next)
        {
            AllElements.Add(next);
        }

        public string Action()
        {
            return Name;
        }

        public void Execute()
        {
            Console.WriteLine(Name);
            foreach (var item in AllElements)
            {
                Console.WriteLine("----------");
                item.Action();
                item.Execute();
            }

        }

    }

    public class Block : IElement
    {
        private string Name { get; set; }

        public Block(string name)
        {
            Name = name;
        }

        public string Action()
        {
            return Name;
        }
        public void Execute()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Cant add to leaf..");
        }

    }

    public class Branch : IElement
    {
     
        public string Name { get; private set; }
        public List<Block> LeftBranches { get; private set; }
        public List<Block> RightBranches { get; private set; }

        public Branch(string name)
        {
            Name = name;
            LeftBranches = new List<Block>();
            RightBranches = new List<Block>();
        }

        public string Action()
        {
            return Name;

        }

        public void Add(Block next, string choice)
        {
            switch (choice)
            {
                case "left":
                    LeftBranches.Add(next);
                    break;
                case "right":
                    RightBranches.Add(next);
                    break;
                default: throw new Exception("no such actions!");
            }
        }


        public void Execute()
        {
            Console.WriteLine(Name);

            if (LeftBranches.Count > 0)
            {
                foreach (var block in LeftBranches)
                {
                    Console.WriteLine("Left branch element: " + block.Action());
                    Console.WriteLine("Cant add to leaf..");
                }
            }

            if (RightBranches.Count > 0)
            {
                foreach (var block in RightBranches)
                {
                    Console.WriteLine("Right branch element: " + block.Action());
                    Console.WriteLine("Cant add to leaf..");
                }
            }



        }
    }
}
