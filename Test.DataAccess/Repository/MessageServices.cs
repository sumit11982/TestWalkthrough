using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DataAccess.Dto;
using Test.DataAccess.Repository.Interface;

namespace Test.DataAccess.Repository
{
   public class MessageServices: IMessageServices
    {
        public MessageDto GetMessages()
        {
            var result = new MessageDto();
            result.Id = 1;
            result.MessageBody = "Hello World";
            result.MessageText = "This is Text Area Hello World!";
            return result;
        }
    }
}
