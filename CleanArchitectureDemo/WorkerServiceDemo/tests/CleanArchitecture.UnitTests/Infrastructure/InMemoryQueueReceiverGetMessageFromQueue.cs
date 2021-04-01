using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Services;
using CleanArchitecture.Infrastructure.Messaging;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.UnitTests
{
    public class InMemoryQueueReceiverGetMessageFromQueue
    {
        private readonly InMemoryQueueReceiver _receiver = new InMemoryQueueReceiver();

        [Fact]
        public async Task ThrowsNullExceptionGivenNull()
        {
            // https://hadihariri.com/2008/10/17/testing-exceptions-with-xunit/
            var ex = await Assert.ThrowsAsync<ArgumentNullException>(() => _receiver.GetMessageFromQueue(null));
        }

        [Fact]
        public async Task ThrowsArgumentExceptionGivenEmpty()
        {
            // https://hadihariri.com/2008/10/17/testing-exceptions-with-xunit/
            var ex = await Assert.ThrowsAsync<ArgumentException>(() => _receiver.GetMessageFromQueue(string.Empty));
        }
    }
}
