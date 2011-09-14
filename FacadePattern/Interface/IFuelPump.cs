using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Interface
{
    public interface IFuelPump
    {
        object IgnitionVolume { get; set; }

        void Pump(object p);
    }
}
