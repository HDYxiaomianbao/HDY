using MendixFunctionInterfaces;

namespace MendixFunction
{
    public class CSharpConverter : ICSharpConverter
    {
        public string Convert(string mendixFunction)
        {
            return ParseMendixFunction(mendixFunction);
        }

        private string ParseMendixFunction(string mendixFunction)
        {
            string result = null, functionName = null;
            MxFunctionContext context = new MxFunctionContext(new MxIdentityFunction());
            if (mendixFunction.StartsWith("'[%"))
            {
                char[] specialChars = new char[] { '\'', '[', ']', '%' };
                functionName = mendixFunction.Trim(specialChars);
                switch (functionName)
                {
                    case "CurrentDateTime":
                        context.SetStrategy(new CurrentDateTimeMxFunction());
                        break;
                    default:
                        break;
                }
            }
            else if (mendixFunction.Contains('('))
            {
                functionName = mendixFunction.Split('(')[0];
                if (functionName.Length > 0)
                {
                    switch (functionName)
                    {
                        case "addDays":
                            context.SetStrategy(new AddDaysMxFunction());
                            break;
                        default:
                            break;
                    }
                }
            }
            result = context.ExecuteStrategy(mendixFunction);
            return result;
        }
    }
}