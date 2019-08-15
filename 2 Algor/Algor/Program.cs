using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Block end = new Block("end", null);
            Block goodbye = new Block("good bye", end);
            Block printx = new Block("print x", goodbye);
            Block printy = new Block("print y", goodbye);
            Block printxy = new Block("print xy", goodbye);
          
            Branch xlessy2 = new Branch("x < y/2 ?", printy, printxy);
            
            Branch xbiggery = new Branch("x > y ?", printx, xlessy2);

            Block lety = new Block("let y = 10", xbiggery);
            Block letx = new Block("let x = 5", lety);
            Block start = new Block("start", letx);

            start.Execute();

            
           
        }
    }

    public interface IElement
    {
        //string Action();
        void Execute();

    }


    public class Block : IElement
    {
        private IElement next;
        private string Name { get; set; }

        public Block(string name, IElement next)
        {
            Name = name;
            this.next = next;
        }
      
        public void Execute()
        {
            Console.WriteLine(Name);
            
            if (next == null) Console.WriteLine("end of alg");
            else next.Execute();
            //Console.WriteLine("Cant add to leaf..");
        }

    }

    public class Branch: IElement
    {
        private IElement next1;
        private IElement next2;
        private string Name { get; set; }

        public Branch(string name, IElement next1, IElement next2)
        {
            Name = name;
            this.next1 = next1;
            this.next2 = next2;
        }


        public void Execute()
        {
            Console.WriteLine(Name);
            Console.WriteLine("1 or 2?");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    next1.Execute();
                    break;
                case 2: next2.Execute();
                    break;
            }


        }
    }
}
