using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Web;
using MVCSendGripJenkinsProDev.Controllers;
using System.Web.Http;
using System.Net.Http;
using MVCSendGripJenkinsProDev.Models;
using System.Net;

namespace MVCSendGridJenkinsProDev.Tests
{
    [TestClass]
    public class NegativeTests
    {
        Email _email;

        [TestInitialize]
        public void SetupTest()
        {
            _email = new Email
            {

            };
        }

        [TestMethod]
        public void SubmitController_GivenEmptyObject_Return501()
        {
            SubmitController controller = new SubmitController();
            Email testEmail = _email;

            //var repo = new SubmitRepository
            //{
            //    AddEmail = email => testEmail
            //};

            HttpResponseMessage result = controller.Post(string.Empty);

            Assert.IsTrue(result.StatusCode == HttpStatusCode.InternalServerError);
        }

        [TestCleanup]
        public void CleanUp()
        {
            _email = null;
        }
    }

    [TestClass]
    public class PositiveTests
    {

    }

    
}
