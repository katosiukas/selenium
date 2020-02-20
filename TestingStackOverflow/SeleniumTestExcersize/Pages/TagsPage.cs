using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestExcersize
{
    public class TagsPage
    {
        [FindsBy(How = How.Id, Using = "tagfilter")]
        public IWebElement TagsSelectFilterField;

        [FindsBy(How = How.CssSelector, Using = "[href*='/questions/tagged/c%23']")]
        public IWebElement TagsSelectCSharp;

        public void enterTagsCSharp()
        {
            TagsSelectFilterField.SendKeys("c#");
        }

        public void clickTagsCSharp()
        {
            TagsSelectCSharp.Click();
        }
    }    
}