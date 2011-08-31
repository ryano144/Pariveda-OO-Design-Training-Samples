using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Interface
{
    public interface IGPSSensorListener
    {
        void OnGpsLockAcquired(float lat, float lon, GPSAccuracyEnum accuracy);
    }
}
