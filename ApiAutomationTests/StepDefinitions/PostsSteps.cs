using NUnit.Framework;
using RestApiAutomationBL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ApiAutomationTests.StepDefinitions
{
    [Binding]
    public class PostsSteps
    {
        [Given(@"I am creating a new POST using (.*) (.*) and (.*)")]
        public void GivenIAmCreatingANewPOSTUsingTitleAndAuthor(int id, String title, String author)
        {
            var response = PostUtils.createPost(id, title, author);
            Assert.AreEqual(id, response.id);
            Assert.AreEqual(title, response.title);
        }

        //[Then(@"I should be able to get response with (.*) (.*) and (.*)")]
        //public void ThenIShouldBeAbleToGetResponseWithTitleAndAuthor(int id, String title, String author)
        //{
        //    throw new PendingStepException();
        //}
    }
}
