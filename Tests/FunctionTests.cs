using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroFirstTest.Tests
{
    public class FunctionTests
    {

        // naming convention - ClassName_MethodName_ExpectedResult
        public static void SomeFunctions_ReturnsBanana_ReturnsString()
        {
            try
            {
                //Arrange - get your variables, classes, etc. that is needed for the function to run
                bool value = true;
                SomeFunctions afunc = new SomeFunctions();


                //Act - exceute the function/method your'e testing
                string result = afunc.ReturnsBanana(value);


                //Assert - whatever is returned, is it what you want? check it.
                if(result == "BAnana")
                {
                    Console.WriteLine("PASSED: SomeFunctions_ReturnsBanana_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: SomeFunctions_ReturnsBanana_ReturnsString");
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
