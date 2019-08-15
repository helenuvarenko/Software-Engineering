using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadphoneService.Models
{
    interface IModel
    {
        bool Readyness(int id, int timeInService);
    }
}
