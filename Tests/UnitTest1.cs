using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GoToHomePage()
        {
            //go to homepage and check if you are at that page            
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void GoToTennisAndSquash() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectTennisAndSquash();
            //Pages.HomePage.SelectMenuItem();
            Assert.IsTrue(Pages.TennisAndSquashPage.IsAtTennisAndSquash());
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
