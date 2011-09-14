using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.Client.NoFacade;
using FacadePattern.Interface;

namespace FacadePattern.Client.Facade
{
public class RemoteStartController
{
    private IEngineFacade engine;
    private ISecurityFacade security;

    public void OnStartPressed() {
        security.LockAndArm();
        engine.Start();
    }

}
}
