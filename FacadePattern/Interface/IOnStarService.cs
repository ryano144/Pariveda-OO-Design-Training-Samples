using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public interface IOnStarService
    {
        void SetGpsLocation(float lat, float lon, GPSAccuracyEnum accuracy);
    }
}
