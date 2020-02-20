using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestExcersize
{
    public static class Pages
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static MainPage Main
        {
            get { return GetPage<MainPage>(); }
        }

        public static NavigationBar Navigation
        {
            get { return GetPage<NavigationBar>(); }
        }

        public static QuestionsPage Questions
        {
            get { return GetPage<QuestionsPage>(); }
        }

        public static TagsPage Tags
        {
            get { return GetPage<TagsPage>(); }
        }
            
    }
}