using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.Client.NoFacade;
using FacadePattern.Interface;

namespace FacadePattern.Client
{
public class RemoteStartController
{
    private IFuelPump fuelPump;
    private IFuelInjector fuelInjector;
    private ISparkPlug sparkPlug;
    private IGearBox gearBox;
    private IOnStar onStar;
    private List<IAutomaticWindow> windows;
    private List<IDoorLock> doorLocks;
    private ICarAlarm alarm;

    public void OnStartPressed() {
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
        fuelPump.Pump(fuelPump.IgnitionVolume);
        fuelInjector.InjectFuel();
        sparkPlug.Spark();
        gearBox.Park();
    }

    }
}
