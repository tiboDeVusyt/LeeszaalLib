﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLib
{
    public class Magazine
    {
        public string Color { get; set; }
        public override string ToString()
        {
            return Color;
        }
    }
}
