using MendixFunctionInterfaces;

namespace MendixFunction
{
    public class MxIdentityFunction : IMxFunctionStrategy
    {
        public string Parse(string mendixFunction)
        {
            return mendixFunction;
        }
    }
}