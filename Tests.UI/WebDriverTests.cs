using AutoPractice10;
using AutoPractice10.Popup;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests.UI
{
    public class WebDriverTests
    {
        [Test]
        [Category("UI")]
        public void FirstUITest()
        {
            IWebDriver driver = new ChromeDriver(@"<specify-path-to-driver>");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");

            Popup popup = new Popup(driver);
            popup.WaitForPopup();
            popup.CloseButton.Click();

            Main mainPage = new Main(driver);
            driver.ScrollIntoView(mainPage.MenuList.Container);
            mainPage.MenuList.Group[0].Container.Click();
            mainPage.MenuList.Group[0].Links[0].Click();
            mainPage.MenuList.Group[3].Container.Click();
            mainPage.MenuList.Group[3].Links[0].Click();

            driver.Close();
            driver.Quit();
        }
    }
}
