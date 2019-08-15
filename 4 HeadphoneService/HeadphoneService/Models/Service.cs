using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadphoneService.Controllers;
using HeadphoneService.Models;
using HeadphoneService.Views;

namespace HeadphoneService.Models
{
    //модел подписана на контроллер
    class Service: IModel
    {
        IView view;

        public List<HeadPhone> DB { get; private set; }

        public Service(List<HeadPhone> db)
        {
            DB = db;
        }

       
        public void Update()
        {          
            view.Display();
        }

        //состояние и проверка на готовность заказа из починки
        public bool Readyness(int id,int timeInService)
        {
            return timeInService >= DB[id].TimeInService;
        }

        public void Add(string name, int time)
        {
            DB.Add(new HeadPhone(DB.Count+1, name, time, false));
        }

       
    }

    class HeadPhone
    {
        public int ID { get; private set; }
        public string HeadphonesName { get; private set; }
        public int TimeInService { get; private set; }
        public bool Ready { get; private set; }

        public HeadPhone(int id, string name, int time, bool ready)
        {
            ID = id;
            HeadphonesName = name;
            TimeInService = time;
            Ready = ready;
        }

        public override string ToString()
        {
            return "Order number " + ID + " is related to " + HeadphonesName;
        }

    }
}
