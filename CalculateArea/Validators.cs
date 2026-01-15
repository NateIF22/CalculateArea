using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateArea
{
    public static class Validators
    {
        public static bool IsMinimumLength(string value, int min)
        {
            return value.Length >= min;
        }
    }
}
