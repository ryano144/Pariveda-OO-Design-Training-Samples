using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.Original
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
            float diff = speed - DesiredSpeed;
            if (diff < -MajorThreshold)
            {
                _gearBox.DownShift();
                _throttle.Accellerate();
            }
            else if (diff < -MinorThreshold)
            {
                _throttle.Accellerate();
            }
            else if (diff > MinorThreshold)
            {
                _breaks.Engage();
            }
        }
    }
}
