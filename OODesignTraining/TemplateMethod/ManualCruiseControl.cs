using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.TemplateMethod
{
public class ManualCruiseControl : CruiseControlBase
{
    public float DesiredSpeed { get; set; }

    protected override float GetDesiredSpeed()
    {
        return DesiredSpeed;
    }
}
}
