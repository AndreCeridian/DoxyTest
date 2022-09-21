using System;

namespace HelloWorld
{
    /// <summary>
    /// this is a class summary
    /// </summary>
    public class TestClass1 : ITestClass1
    {
        /// <summary>
        /// method summary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public void TestFuction(string key)
        {

            Console.WriteLine("");
        }

        /// <summary>
        /// method summary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public void TestFuction2(string key) => Console.WriteLine("");
    }
}
