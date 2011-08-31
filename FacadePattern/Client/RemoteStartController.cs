using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Client
{
    public class OnStarRemoteStartController
    {
    private IIgnition ignition;
    private IOnStar onStar;
    public OnStarRemoteStartController(IIgnition i, 
                                        IOnStar l) {
        ignition = i;
        onStar = l;
    }
    public void OnStartPressed() {
        onStar.LockDoors();
        onStar.GetGpsLocation();
        ignition.Start();
    }

    }
}
