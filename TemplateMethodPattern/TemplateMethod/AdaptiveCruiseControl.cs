using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.TemplateMethod
{
public class AdaptiveCruiseControl : CruiseControlBase
{
    private IRadarSensor _radarSensor;
    private float DesiredSpeed { get; set; }

    protected override float GetDesiredSpeed()
    {
        if (_radarSensor.CarDetected)
        {
            return _radarSensor.GetSpeedOfCarInFront();
        }
        return DesiredSpeed;
    }

    protected override float GetCurrentSpeed()
    {
        return speedSensor.ReadSpeedNow();
    }
}
}
