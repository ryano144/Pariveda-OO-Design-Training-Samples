using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.Client.NoFacade;
using FacadePattern.Client;
using FacadePattern.Interface;

namespace FacadePattern
{
    public class SecurityFacade
    {
            private IOnStar onStar;
    private List<IAutomaticWindow> windows;
    private List<IDoorLock> doorLocks;
    private ICarAlarm alarm;

    public void LockAndArm()
    {
        foreach (IDoorLock doorLock in doorLocks)
        {
            doorLock.Lock();
        }
        foreach (IAutomaticWindow window in windows)
        {
            if (window.IsDown)
            {
                window.Up();
            }
        }
        onStar.GetGpsLocation();
        alarm.ArmDoorSensors();
        alarm.ArmWeightSensors(WeightSensor.SensitiveWeight);
    }
    }
}
