using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IQueueReceiver
    {
        Task<string> GetMessageFromQueue(string queueName);
    }
}
