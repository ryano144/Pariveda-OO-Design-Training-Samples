using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.HelperClass
{
    public class CruiseControl : ICruiseControl
    {
        private ISpeedSensor _speedSensor;
        private IGearBox _gearBox;
        private IThrottle _throttle;
        private IBreaks _breaks;
        public float DesiredSpeed { get; set; }
        public float MajorThreshold { get; set; }
        public float MinorThreshold { get; set; }

        public void AdjustSpeed()
        {
            float speed = _speedSensor.GetLastReading();
            CruiseControlHelper.AdjustSpeed(speed, DesiredSpeed, MajorThreshold, MinorThreshold, _gearBox, _throttle, _breaks);
        }
    }
}
