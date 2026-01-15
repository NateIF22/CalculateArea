using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    public static class Validators
    {
        public static bool IsMinimumLength(string value, int min)
        {
            return value.Length <= min;
        }
        
        public static bool IsMaximumLength(string value, int max)
        {
            return value.Length >= max;
        }

        public static bool IsInteger(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
