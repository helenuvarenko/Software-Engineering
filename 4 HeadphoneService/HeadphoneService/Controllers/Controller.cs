using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadphoneService.Views;
using HeadphoneService.Models;

namespace HeadphoneService.Controllers
{
    //контроллер подписан на вью
    class Controller
    {
       
        Service controllerService;

        public Controller(Service newService)
        {
            controllerService = newService;     
        }

        public void AddItem(string name, int time)
        {
            controllerService.Add(name, time);
        }

        
    }
}
