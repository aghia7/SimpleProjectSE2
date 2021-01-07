using SimpleProjectSE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectSE2.Repositories.Interfaces
{
    public interface IQueueRepository
    {
        Task<bool> AddMessage(Message message);
        Task<bool> SetHandled(Guid messageId);
        Task<Message> GetUnhandledEmailMessage();
        Task<Message> GetUnhandledLoggingMessage();
    }
}
