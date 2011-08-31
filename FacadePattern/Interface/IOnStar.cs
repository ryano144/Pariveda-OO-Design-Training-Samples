﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.Interface;

namespace FacadePattern.Client
{
    public interface IOnStar : IGPSSensorListener
    {
        void LockDoors();

        void GetGpsLocation();
    }
}
