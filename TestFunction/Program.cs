﻿
using TestFunction;


foreach (var i in new int[] { int.MinValue, -15, -11, -10, -9, -1, 0, 1, 2, 4, 5, 6, 10, int.MaxValue })
{
    try
    {
        Console.WriteLine(NewFunction.EquationFunction(i));
    }
    catch
    {
        Console.WriteLine("Threw an exception!");
    }
}