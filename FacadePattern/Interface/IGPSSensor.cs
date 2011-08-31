using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public interface IGPSSensor
    {
        bool HasLock { get; set; }

        void AcquireSatalites(OnStar onStar);

        GPSAccuracyEnum Accuracy { get; set; }

        float Longitude { get; set; }

        float Latitude { get; set; }
    }
}
