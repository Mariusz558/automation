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
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());            
        }

        [TestMethod]
        public void GoToFitnessAndGym()
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectFitnessAndGym();
            Assert.IsTrue(Pages.FitnessAndGymPage.IsAtFitnessAndGym());            
        }

        [TestMethod]
        public void GoToTennisAndSquash() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectTennisAndSquash();            
            Assert.IsTrue(Pages.TennisAndSquashPage.IsAtTennisAndSquash());                        
        }

        [TestMethod]
        public void GoToSpaPage() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectSpa();
            Assert.IsTrue(Pages.SpaPage.IsAtSpaPage());            
        }

        [TestMethod]
        public void GoToBodySpacePage() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectBodySpace();
            Assert.IsTrue(Pages.BodySpacePage.IsAtBodySpacePage());            
        }

        [TestMethod]
        public void GoToPlaygroundPage() 
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectPlayground();
            Assert.IsTrue(Pages.PlaygroundPage.IsAtPlaygroundPage());            
        }

    }
}
