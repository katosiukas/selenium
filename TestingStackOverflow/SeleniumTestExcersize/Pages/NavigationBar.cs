using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestExcersize
{
    public class NavigationBar
    {
        [FindsBy(How = How.ClassName, Using = "ps-relative")]
        public IWebElement TopBarFirstDropdown;

        [FindsBy(How = How.ClassName, Using = "-link--channel-name")]
        public IWebElement TopBarFirstDropdownQuestions;

        [FindsBy(How = How.Id, Using = "nav-tags")]
        public IWebElement TopBarFirstDropdownTags;

        public void clickTopBarFirstDropdown()
        {
            TopBarFirstDropdown.Click();
        }

        public void clickTopBarFirstDropdownQuestions()
        {
            TopBarFirstDropdownQuestions.Click();
        }

        public void clickTopBarFirstDropdownTags()
        {
            TopBarFirstDropdownTags.Click();
        }
    }
}