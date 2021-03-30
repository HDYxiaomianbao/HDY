using MendixFunctionInterfaces;

namespace MendixFunction
{
    public class AddDaysMxFunction : IMxFunctionStrategy
    {
        public string Parse(string mendixFunction)
        {
            string result = null;

            string[] parts = mendixFunction.Split('(');
            string functionName = parts[0];
            string[] parameters = parts[1].TrimEnd(')').Split(',');
            if (parameters[0] == "'[%CurrentDateTime%]'")
            {
                result = $"DateTime.Now.AddDays({parameters[1].Trim()})";
            }

            return result;
        }
    }
}