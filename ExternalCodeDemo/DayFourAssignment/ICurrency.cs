using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalCodeDemo.DayFourAssignment;
public interface ICurrency
{
    static abstract double MinValue { get; }
    static abstract double MaxValue { get; }
}

