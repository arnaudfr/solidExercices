﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    internal interface IOperation
    {
        decimal Calculate(List<decimal> numbers);
    }
}
