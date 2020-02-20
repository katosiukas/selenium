using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTestExcersize;

namespace Excersize.UI.Tests
{
    [TestClass]
    public class OverflowTests : TestBase
    {
        [TestMethod]
        public void SORecentActivityTest()
        {
            Pages.Main.Goto();                                      // Goto www.stackoverflow.com
            Pages.Navigation.clickTopBarFirstDropdown();            // Click Stackoverflow meniu
            Pages.Navigation.clickTopBarFirstDropdownQuestions();   // Click Stack Overflow 
            Pages.Questions.clickQuestionsFilter();                 // Click Filter button
            Pages.Questions.clickQuestionsNoAcceptedAnswers();      // Select No accepted answer
            Pages.Questions.clickQuestionsRecentActivity();         // Select Recent activity
            Pages.Questions.enterJavascriptTag();                   // Enter "javascript" in search field
            Pages.Questions.clickQuestionsApplyFilter();            // Click Apply filter

            Assert.IsTrue(Browser.Title.Contains("Custom filtered 'javascript' questions - Stack Overflow")); // Check results
            Assert.IsTrue(Browser.CurrentURL.Contains("https://stackoverflow.com/questions/tagged/javascript?sort=RecentActivity&filters=NoAcceptedAnswer&edited=true"));   //Check results second option

        }

        [TestMethod]
        public void SOTagsCsharpTest()
        {
            Pages.Main.Goto();
            Pages.Navigation.clickTopBarFirstDropdown();            
            Pages.Navigation.clickTopBarFirstDropdownTags();        // Click Tags
            Pages.Tags.enterTagsCSharp();                           // Enter "c#" in tags field
            Pages.Tags.clickTagsCSharp();                           // Click "c#" tag

            Assert.IsTrue(Browser.Title.Contains("Newest 'c#' Questions - Stack Overflow"));                //Check results
            Assert.IsTrue(Browser.CurrentURL.Contains("https://stackoverflow.com/questions/tagged/c%23"));  //Check results second option
        }
    }
}