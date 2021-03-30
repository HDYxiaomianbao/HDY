using MendixFunctionInterfaces;

namespace MendixFunction
{
    public class MxFunctionContext
    {
        private IMxFunctionStrategy _strategy;

        public MxFunctionContext(IMxFunctionStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IMxFunctionStrategy strategy)
        {
            this._strategy = strategy;
        }

        public string ExecuteStrategy(string mendixFunction)
        {
            return _strategy.Parse(mendixFunction);
        }
    }
}