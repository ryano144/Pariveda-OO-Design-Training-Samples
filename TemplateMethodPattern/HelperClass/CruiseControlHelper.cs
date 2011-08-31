using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    public static class CruiseControlHelper
    {
        public static void AdjustSpeed(float speed, float desiredSpeed, float majorThreshold, float minorThreshold, IGearBox gearBox, IThrottle throttle, IBreaks breaks)
        {
            float diff = speed - desiredSpeed;
            if (diff < -majorThreshold)
            {
                gearBox.DownShift();
                throttle.Accellerate();
            }
            else if (diff < -minorThreshold)
            {
                throttle.Accellerate();
            }
            else if (diff > minorThreshold)
            {
                breaks.Engage();
            }
        }



    }
}
