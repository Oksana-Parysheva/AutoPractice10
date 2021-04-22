using OpenQA.Selenium;
using System;

namespace AutoPractice10
{
    public class Main
    {
        private IWebDriver _driver;

        public Main(IWebDriver driver)
        {
            _driver = driver;
        }

        public MenuList MenuList
            => new MenuList(_driver, _driver.FindElement(By.Id("treemenu")));
    }
}
