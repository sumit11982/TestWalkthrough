using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DataAccess.Dto;

namespace Test.DataAccess.Repository.Interface
{
    public interface IMessageServices
    {
        MessageDto GetMessages();
    }
}
