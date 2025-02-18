using System;
using System.Collections.Immutable;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AZ_functions_tester
{
    public class BrregTimer
    {
        private readonly ILogger _logger;

        public BrregTimer(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BrregTimer>();
        }

        [Function("BrregTimer")]
        public async Task RunAsync([TimerTrigger("%timertriggersetting%")] TimerInfo myTimer) // timertriggersetting --> innstilling i azure environment
        {
            // default innstilling i azure --> 55 11 * 2 4 *
            // ekstra stjerne må legges til i azure miljøet, ellers får man HTTP-40x feil når man skal kjøre timer i Azure.
            // 55 11 * 2 4 * --> kl 11:55, torsdager i måned 2 (dvs februar).

            _logger.LogInformation($"Fetching from Brreg at: {DateTime.Now}");

            List<string> orgIds = new List<string>();
            orgIds.Add("946598038");
            orgIds.Add("913859529");
            orgIds.Add("918000763");
            orgIds.Add("941612474");
            orgIds.Add("997725646");
            orgIds.Add("825603042");
            var randomPos = new Random().Next(orgIds.Count);

            BrregCaller caller = new BrregCaller();
            var companyInfo = await caller.getData(orgIds[randomPos]);

            _logger.LogInformation($"Data received for list position: {randomPos}");
            _logger.LogInformation(System.Environment.NewLine);
            _logger.LogInformation(System.Environment.NewLine);
            _logger.LogInformation($"{Newtonsoft.Json.JsonConvert.SerializeObject(companyInfo)}");

            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next fetching at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
