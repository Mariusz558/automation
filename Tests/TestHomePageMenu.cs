using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class TestHomePageMenu
    {
        [TestMethod]
        public void GoToHomePage()
        {
            //go to homepage and check if you are at that page            
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());
            Pages.HomePage.GoTo();
        }

        [TestMethod]
        public void GoToFitnessAndGym()
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectFitnessAndGym();
            Assert.IsTrue(Pages.FitnessAndGymPage.IsAtFitnessAndGym());
            Pages.HomePage.GoTo();
        }

        [TestMethod]
        public void GoToTennisAndSquash() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectTennisAndSquash();            
            Assert.IsTrue(Pages.TennisAndSquashPage.IsAtTennisAndSquash());
            Pages.HomePage.GoTo();            
        }

        [TestMethod]
        public void GoToSpaPage() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectSpa();
            Assert.IsTrue(Pages.SpaPage.IsAtSpaPage());
            Pages.HomePage.GoTo();
        }

        [TestMethod]
        public void GoToBodySpacePage() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectBodySpace();
            Assert.IsTrue(Pages.BodySpacePage.IsAtBodySpacePage());
            Pages.HomePage.GoTo();
        }

        [TestMethod]
        public void GoToPlaygroundPage() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectPlayground();
            Assert.IsTrue(Pages.PlaygroundPage.IsAtPlaygroundPage());
            Pages.HomePage.GoTo();
        }
        
        [TestCleanup]
        public void CleanUp()
        {
            //Browser.Close();
        }

    }
}
