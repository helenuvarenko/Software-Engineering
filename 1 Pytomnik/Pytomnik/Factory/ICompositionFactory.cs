using System;
using Pytomnik.Flowers;
using Pytomnik.Kustarniki;
using Pytomnik.Travy;

namespace Pytomnik
{
    interface ICompositionFactory
    {
        IFlowers CreateF();
        IKustarniki CreateK();
        ITravy CreateT();

       string Description();
    }

}
