using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class IgnitionException : ApplicationException
    {
        public IgnitionException(NoFuelException e)
            : base("Error starting ignition", e)
        {
            // TODO: Complete member initialization
            
        }
    }
}
