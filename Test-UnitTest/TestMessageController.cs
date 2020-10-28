using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DataAccess.Dto;
using TestAPI.Controllers;

namespace Test_UnitTest
{
    [TestClass]
    public class TestMessageController
    {
        [TestMethod]
        public void GetAllMessages_ShouldReturnAllMessages()
        {
            var controller = new MessageController();
            MessageDto result = controller.GetMessages() as MessageDto;
            Assert.AreEqual(GetTestMessage().MessageText, result.MessageText);
        }

        private MessageDto GetTestMessage()
        {
            var testProducts = new MessageDto();
            testProducts =new MessageDto { Id = 1, MessageBody = "Hello World", MessageText = "This is Text Area Hello World!" };
            return testProducts;
        }
    }
}
