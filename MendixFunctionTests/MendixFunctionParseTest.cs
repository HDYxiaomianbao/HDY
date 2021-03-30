using Xunit;
using MendixFunction;
using MendixFunctionInterfaces;
 
namespace MendixFunctionTests
{
    public class MendixFunctionParseTest
    {
        [Theory]
        [InlineData("DateTime.Now.AddDays(3)", "addDays('[%CurrentDateTime%]', 3)")]
        [InlineData("DateTime.Now.AddDays(-2)", "addDays('[%CurrentDateTime%]', -2)")]
        public void TestAddDays(string expectedCSCode, string mendixFunction)
        {
            ExecuteTest(expectedCSCode, mendixFunction);
        }

        [Theory]
        [InlineData("DateTime.Now", "'[%CurrentDateTime%]'")]
        public void TestCurrentDayTime(string expectedCSCode, string mendixFunction)
        {
            ExecuteTest(expectedCSCode, mendixFunction);
        }

        private static void ExecuteTest(string expectedCSCode, string mendixFunction)
        {
            ICSharpConverter converter = new CSharpConverter();
            string csCode = converter.Convert(mendixFunction);
            Assert.Equal(expectedCSCode, csCode);
        }
    }
}