using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTestExcersize
{
    [TestClass]
    public class TestBase
    {
        
        [ClassInitialize]
        public void Initialize()
        {
            Browser.Initialize();
        }

        [ClassCleanup]
        public void ClassCleanup()
        {
            Browser.Close();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            //here could be log out of page
        }
        
    }

}