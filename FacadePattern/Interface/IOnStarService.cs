using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Interface
{
    public interface IOnStarService
    {
        void SetGpsLocation(float lat, float lon, GPSAccuracyEnum accuracy);
    }
}
