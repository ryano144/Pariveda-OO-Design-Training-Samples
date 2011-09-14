using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Interface
{
    public interface ICarAlarm
    {
        void ArmDoorSensors();

        void ArmWeightSensors();

        void ArmWeightSensors(float weightThreshold);
    }
}
