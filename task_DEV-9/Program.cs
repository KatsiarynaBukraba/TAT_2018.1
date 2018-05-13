using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using task_DEV9;

namespace BMW
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HomePage homePage = new HomePage();
                homePage.OpenPageForBrand("BMW");

                BrandPage brandPage = new BrandPage(homePage.driver);
                brandPage.OpenPageForModel("M5");
                brandPage.SortByPrice();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
