using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    public interface ISpeedSensor
    {
        float GetLastReading();

        float ReadSpeedNow();
    }
}
