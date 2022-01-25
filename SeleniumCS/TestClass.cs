// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCS.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCS
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement rcookieButton = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-dialog-accept-button']"));
            rcookieButton.Click();
            IWebElement registrationFormButton = driver.FindElement(By.XPath(".//*[@data-testid='open-registration-form-button']"));
            registrationFormButton.Click();
            Thread.Sleep(1000);
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(4);
            //element.SelectByText("Lut");
            //element.SelectByValue("6");
        }

        [Test, Category("Regressioin Testing")]
        public void TestMethod2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");

        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);

        }
    }
}
