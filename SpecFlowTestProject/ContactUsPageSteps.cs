using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowTestProject
{
    [Binding]
    public class ContactUsPageSteps
    {
        private IWebDriver driver;
 

        [BeforeScenario()]
        public void Setup()
        {
            driver = new InternetExplorerDriver();
        }

        [AfterScenario()]
        public void TearDown()
        {

            driver.Quit();

        }


        [Given(@"I am on the QAWorks Contact Us Page")]
        public void GivenIAmOnTheQAWorksSite()
        {
            driver.Navigate().GoToUrl("http://qaworks.com/contact.aspx");
        }
        
        
        [Given(@"I enter the username ""(.*)""")]
        public void GivenIEnterTheUsername(string username)
        {
            driver.FindElement(By.Id("ctl00_MainContent_NameBox")).SendKeys(username);
        }
        
        [Given(@"I enter the email ""(.*)""")]
        public void GivenIEnterTheEmail(string email)
        { 
                 driver.FindElement(By.Id("ctl00_MainContent_EmailBox")).SendKeys(email);
        }
        
        [Given(@"I enter a message ""(.*)""")]
        public void GivenIEnterAMessage(string message)
        { 
                   driver.FindElement(By.Id("ctl00_MainContent_MessageBox")).SendKeys(message);
        }
        
        [When(@"I click the send button")]
        public void WhenIPressTheSendButton()
        {
            driver.FindElement(By.Id("ctl00_MainContent_SendButton")).Click();
        }
        
        [Then(@"I should be able to contact QAWorks successfully")]
        public void ThenIShouldBeAbleToContactQAWorksSuccessfully()
        {
            //This is not a valid way to confirm to the user that the contact was successful. There should be some kind of notification message
            //TODO: If the application provides a success message, we can always validate if it was successful or not.
            //TODO: Considering we are validating a valid business use case scenario, I'd expect this page to return me a success message
            //when the user clicks on SEND Button on ContactUs Page
          //  Assert.IsTrue(driver.FindElement(By.Id("ctl00_MainContent_NameBox")).GetAttribute("Value").Equals(""));
          //  Assert.IsTrue(driver.FindElement(By.Id("ctl00_MainContent_EmailBox")).GetAttribute("Value").Equals(""));
          //  Assert.IsTrue(driver.FindElement(By.Id("ctl00_MainContent_MessageBox")).GetAttribute("Value").Equals(""));
        }
    }
}
