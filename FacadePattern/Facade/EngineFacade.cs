using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.Interface;

namespace FacadePattern
{
public class EngineFacade : IEngineFacade
{
    private IFuelPump fuelPump;
    private IFuelInjector fuelInjector;
    private ISparkPlug sparkPlug;
    private IGearBox gearBox;
    private bool isStarted;

    public EngineFacade(IFuelInjector i, 
                        ISparkPlug s,
                        IFuelPump p) {
        fuelInjector = i;
        sparkPlug = s;
        fuelPump = p;
        isStarted = false;
    }

    public void Start() {
        if(isStarted) return;
        try {
            fuelPump.Pump(fuelPump.IgnitionVolume);
            fuelInjector.InjectFuel();
            sparkPlug.Spark();
            isStarted = true;
        }
        catch(NoFuelException e) {
            throw new IgnitionException(e);
        }
    }

    public bool IsStarted {
        get { return isStarted; }
    }
} 

}
