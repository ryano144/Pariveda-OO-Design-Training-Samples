﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Interface
{
    public interface IAutomaticWindow
    {
        bool IsDown { get; }

        void Up();
    }
}
