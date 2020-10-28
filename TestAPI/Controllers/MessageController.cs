using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.DataAccess.Dto;
using Test.DataAccess.Repository;

namespace TestAPI.Controllers
{
    
    public class MessageController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [HttpGet]
        [Route("API/GetMessages")]
        public MessageDto GetMessages()
        {
            log.Info("GetMessages:: Start");
            var messageService = new MessageServices();
            var result = messageService.GetMessages();
            log.Info("GetMessages:: End");
            return result;
        }
    }
}
