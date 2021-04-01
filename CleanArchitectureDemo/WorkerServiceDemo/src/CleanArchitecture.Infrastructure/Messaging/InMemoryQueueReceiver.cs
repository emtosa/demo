using Ardalis.GuardClauses;
using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Messaging
{
    public class InMemoryQueueReceiver : IQueueReceiver
    {
        public async Task<string> GetMessageFromQueue(string queueName)
        {
            Guard.Against.NullOrWhiteSpace(queueName, nameof(queueName));
            //Guard.Against.NullOrEmpty(queueName, nameof(queueName));
            //if (string.IsNullOrWhiteSpace(queueName)) throw new ArgumentNullException("queueName is required", "queueName");
            //if (string.IsNullOrEmpty(queueName)) throw new ArgumentException("queueName is required", "queueName");
            // queueName = queueName ?? throw new Exception("Fail");
            return await Task.FromResult(string.Empty);
        }
    }
}
