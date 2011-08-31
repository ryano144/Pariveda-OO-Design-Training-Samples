using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.CopyPaste
{
    public class AdaptiveCruiseControl : ICruiseControl
    {
        private IRadarSensor _radarSensor;
        private ISpeedSensor _speedSensor;
        private IGearBox _gearBox;
        private IThrottle _throttle;
        private IBreaks _breaks;
        public float DesiredSpeed { get; set; }
        public float MajorThreshold { get; set; }
        public float MinorThreshold { get; set; }

        public void AdjustSpeed()
        {
            float speed = _speedSensor.ReadSpeedNow();
            float desiredSpeed = _radarSensor.CarDetected ? _radarSensor.GetSpeedOfCarInFront() : DesiredSpeed;

            float diff = speed - desiredSpeed;
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
