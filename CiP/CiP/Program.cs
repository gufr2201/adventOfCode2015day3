using CiP;
using System;


class Program
{
    static void Main()
    {

        // Now you can access the ReadFile class from the CiP namespace
        string directions = ReadFile.ReadFileFunction(); // This calls the Main() method in the ReadFile class
        Routes.RouteCalculator(directions);
    }
}

