using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.TemplateMethod
{
    public abstract class CruiseControlBase : ICruiseControl
    {
        protected ISpeedSensor speedSensor;
        private ISpeedSensor _speedSensor;
        private IGearBox _gearBox;
        private IThrottle _throttle;
        private IBreaks _breaks;

        public float MajorThreshold { get; set; }
        public float MinorThreshold { get; set; }

        public void AdjustSpeed()
        {
            float speed = GetCurrentSpeed();
            float diff = speed - GetDesiredSpeed();
            if (diff < -MajorThreshold)
            {
                DownShift();
                Accellerate();
            }
            else if (diff < -MinorThreshold)
            {
                Accellerate();
            }
            else if (diff > MinorThreshold)
            {
                ApplyBreak();
            }
        }

        protected virtual float GetCurrentSpeed()
        {
            return speedSensor.GetLastReading();
        }
        protected abstract float GetDesiredSpeed();


        private void DownShift()
        {
            _gearBox.DownShift();
        }

        private void Accellerate()
        {
            _throttle.Accellerate();
        }

        private void ApplyBreak()
        {
            _breaks.Engage();
        }



    }
}
