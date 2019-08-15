using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadphoneService.Controllers;
using HeadphoneService.Models;

namespace HeadphoneService.Views
{
    //вью подписан на модел
    class Reception: IView
    {
        Controller viewController;
        Service viewService;


        

        public Reception(Service newService, Controller newController)
        {
            viewService = newService;
            viewController = newController;
        }

        public void Display()
        {
            Console.WriteLine("Current orders: ");
            foreach(HeadPhone item in viewService.DB)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void MakeOrder(string name, int time)
        {
            viewController.AddItem(name, time);
            
        }

        public void Check(int id, int time)
        {
            Console.WriteLine();
            Console.WriteLine("Let`s check order number " + id);
            Console.WriteLine("Is have been in service for " + time + " hours");

            if (viewService.Readyness(id, time))
                Console.WriteLine("Your order is ready");
            else Console.WriteLine("Your order is in progress");
        }
    }
}
