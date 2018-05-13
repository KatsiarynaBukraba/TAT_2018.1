using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace BMW
{
    class HomePage
    {
        public IWebDriver driver = new ChromeDriver();

        public void OpenPageForBrand(string brand)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20); //максимальное время, которое может ждать программа
            driver.Manage().Window.Maximize();
            driver.Url = "https://av.by";

            IWebElement element = driver.FindElement(By.XPath("//a[contains(.,'"+brand+"')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", element);
            element.Click();
        }
    }
}
