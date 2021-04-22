using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace AutoPractice10
{
    public class MenuGroup
    {
        private IWebDriver _driver;
        public IWebElement Container;

        public MenuGroup(IWebDriver driver, IWebElement container)
        {
            _driver = driver;
            Container = container;
        }

        public List<IWebElement> Links
            => Container.FindElements(By.XPath(".//li/a")).ToList();
    }
}
