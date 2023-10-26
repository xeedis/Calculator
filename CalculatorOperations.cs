using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator;
public class CalculatorOperations
{
    public static double CalculateResult(string operation)
    {
        var fmt = new NumberFormatInfo();
        fmt.NegativeSign = "-";
        if (operation.Contains("+"))
        {
            var addElements = operation.Split('+');

            return double.Parse(addElements[0],fmt) + double.Parse(addElements[1],fmt);
        }
        if (operation.Contains("-"))
        {
            var addElements = operation.Split('-');

            return double.Parse(addElements[0]) - double.Parse(addElements[1]);
        }
        if (operation.Contains("/"))
        {
            var addElements = operation.Split('/');

            return double.Parse(addElements[0]) / double.Parse(addElements[1]);
        }
        if (operation.Contains("*"))
        {
            var addElements = operation.Split('*');

            return double.Parse(addElements[0]) * double.Parse(addElements[1]);
        }
        return default;

    }

    public static bool ConatinsOperation(string operation)
    {
        return operation.Contains('+') || operation.Contains("-") || operation.Contains('*') || operation.Contains("/"); 
    }
}
