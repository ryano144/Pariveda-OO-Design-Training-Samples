using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class Ignition : IIgnition 
{
    private IFuelInjector fuelInjector;
    private ISparkPlug sparkPlug;
    private  bool isStarted;

    public Ignition(IFuelInjector i, 
                        ISparkPlug p) {
        fuelInjector = i;
        sparkPlug = p;
        isStarted = false;
    }

    public void Start() {
        if(isStarted) return;
        try {
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
