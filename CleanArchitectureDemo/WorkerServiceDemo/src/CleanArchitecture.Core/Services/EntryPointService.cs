﻿using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Services
{
    public class EntryPointService : IEntryPointService
    {
        private readonly ILoggerAdapter<EntryPointService> _logger;
        private readonly IQueueReceiver _queueReceiver;
        private readonly IQueueSender _queueSender;

        public EntryPointService(ILoggerAdapter<EntryPointService> logger,
            IQueueReceiver queueReceiver,
            IQueueSender queueSender)
        {
            _logger = logger;
            _queueReceiver = queueReceiver;
            _queueSender = queueSender;
        }

        public async Task ExecuteAsync()
        {
            _logger.LogInformation("{service} running at: {time}", nameof(EntryPointService), DateTimeOffset.Now);
            // read from the queue
            await _queueReceiver.GetMessageFromQueue("");

            // do some work
        }
    }
}
