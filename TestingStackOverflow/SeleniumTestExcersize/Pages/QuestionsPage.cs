using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestExcersize
{
    public class QuestionsPage
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 's-btn__filled')]")]
        public IWebElement QuestionsFilter;

        [FindsBy(How = How.XPath, Using = "//input[@value = 'NoAcceptedAnswer']")]
        public IWebElement QuestionsNoAcceptedAnswers;

        [FindsBy(How = How.XPath, Using = "//input[@value = 'RecentActivity']")]
        public IWebElement QuestionsRecentActivity;

        [FindsBy(How = How.ClassName, Using = "js-tageditor-replacing")]
        public IWebElement QuestionsSelectTagEditor;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'s-btn__primary')]")]
        public IWebElement QuestionsApplyFilter;

        public void clickQuestionsFilter()
        {
            QuestionsFilter.Click();
        }

        public void clickQuestionsNoAcceptedAnswers()
        {
            QuestionsNoAcceptedAnswers.Click();
        }

        public void clickQuestionsRecentActivity()
        {
            QuestionsRecentActivity.Click();
        }

        public void enterJavascriptTag()
        {
            QuestionsSelectTagEditor.SendKeys("javascript");
        }

        public void clickQuestionsApplyFilter()
        {
            QuestionsApplyFilter.Click();
        }
    }
}  