using System;
using OpenQA.Selenium;

namespace task_DEV9
{
    class BrandPage
    {
        public IWebDriver driver;

        public BrandPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenPageForModel(string model)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(.,'" + model + "')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", element);
            element.Click();
        }
    }
}
