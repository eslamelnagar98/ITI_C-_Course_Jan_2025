﻿namespace Day3.GenericNumericRange;
public interface ITemperatureUnit
{
    static abstract double MinValue { get; }
    static abstract double MaxValue { get; }
}
