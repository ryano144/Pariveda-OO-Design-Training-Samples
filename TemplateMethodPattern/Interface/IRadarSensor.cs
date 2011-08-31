using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    public interface IRadarSensor
    {
        bool CarDetected { get; set; }

        float GetSpeedOfCarInFront();
    }
}
