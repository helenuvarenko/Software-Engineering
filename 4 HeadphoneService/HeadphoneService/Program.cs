using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadphoneService.Controllers;
using HeadphoneService.Models;
using HeadphoneService.Views;

namespace HeadphoneService
{
    //эта программа сделана по шаблону mvc

    /*
     Змоделювати систему сервiсного центру (СЦ). 
     Iнтерфейсом вважати приймальню центру, куди користувач вiдносить навушники на ремонт. 
     Користувач також може переглянути на внутрiшньому монiторi СЦ номер та стан замовлення. 
     Пiсля прийому навушникiв iнший працiвник СЦ вiдносить пристрiй на склад та вносить 
     необхiднi змiни до даних, на основi яких працює монiтор у приймальнi. 
     Пiсля завершення ремонту навушники позначаються як вiдремонтованi. */


    /* что она должна делать: есть клиент, который приходит сдать свои наушники в ремонт. 
     далее его запрос перенаправляется к сотруднику на склад и там их ремонтируют. 
     клиент может отследживать состояние заказа на внутреннем мониторе сервисного центра.

     вью = юзер интерфейс = приёмная
     модел = бизнес логика = сервисный центр 
     контроллер = связь между вью и модел 

     контроллер подписан на вью, модел на контроллер, вью на модел

     */

    class Program
    {
        static void Main(string[] args)
        {

            List<HeadPhone> db = new List<HeadPhone>
            {
                new HeadPhone(0, "Xiaomi Piston 3", 3, false),
                new HeadPhone(1, "Beats Solo2 Wireless", 1, false),
                new HeadPhone(2, "Marshall Major II", 6, false)
            };
          
               
            Service compToCopy = new Service(db);
            Controller compController = new Controller(compToCopy);
            Reception compReception = new Reception(compToCopy, compController);


         
               
            compReception.MakeOrder("Sony SBH70", 3);
            compReception.MakeOrder("Philips SHE3590", 1);
            compReception.MakeOrder("Fiio F9 Pro", 6);

            compReception.Display();
            
            compReception.Check(5, 6);

            Console.ReadKey();
           




        }
    }
}
