using MendixFunctionInterfaces;
using System;

namespace MendixFunction
{
    public class CurrentDateTimeMxFunction : IMxFunctionStrategy
    {
        public string Parse(string mendixFunction)
        {
            string result = null;

            if (mendixFunction != "'[%CurrentDateTime%]'")
            {
                throw new ArgumentException("Invalid value for argument", nameof(mendixFunction));
            }

            result = "DateTime.Now";

            return result;
        }
    }
}