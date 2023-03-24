﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAdhocToolchain.Core.Variables
{
    public class Variable
    {
        public AdhocSymbol Symbol { get; set; }

        public override string ToString()
        {
            return $"Variable: {Symbol}";
        }
    }
}
