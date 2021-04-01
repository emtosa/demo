using CleanArchitecture.Core.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILoggerAdapter<Worker> _logger;
        private readonly IEntryPointService _entryPointService;
        private readonly WorkerSettings _settings;

        public Worker(ILoggerAdapter<Worker> logger,
            IEntryPointService entryPointService,
            WorkerSettings settings)
        {
            _logger = logger;
            _entryPointService = entryPointService;
            _settings = settings;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("CleanArchitecture.Worker running at: {time}", nameof(Worker), DateTimeOffset.Now);
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(_settings.DelayMilliseconds, stoppingToken); // TODO: Move delay to appSettings
            }
            _logger.LogInformation("CleanArchitecture.Worker stopping at: {time}", nameof(Worker), DateTimeOffset.Now);
        }
    }
}
