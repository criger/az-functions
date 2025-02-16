using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace criger
{
    public class BrregFetcher
    {
        private readonly ILogger<BrregFetcher> _logger;

        public BrregFetcher(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BrregFetcher>();
        }

        [Function("BrregFetcherFunction")]
        public async Task<HttpResponseData> StaticOrgId([HttpTrigger(
            AuthorizationLevel.Anonymous, 
            "get", 
            Route = "getSopraSteria")] 
        HttpRequestData req)
        {
            var response = req.CreateResponse();
            BrregCaller brregCaller = new BrregCaller();
            BrregJSONReply brregJSONReply = await brregCaller.getData("910909088");

            await response.WriteAsJsonAsync(brregJSONReply);

            return response;
        }

        [Function("BrregFetcherParam")]
        public async Task<HttpResponseData> OrgId([HttpTrigger(
            AuthorizationLevel.Anonymous,
            "get",
            Route = "organization")]
        HttpRequestData req)
        {
            var response = req.CreateResponse();
            BrregCaller brregCaller = new BrregCaller();
            string orgId = req.Query["orgId"];

            BrregJSONReply brregJSONReply = await brregCaller.getData(orgId);

            await response.WriteAsJsonAsync(brregJSONReply);

            return response;
        }

        [Function("BrregFetcherByName")]
        public async Task<HttpResponseData> GetByName([HttpTrigger(
            AuthorizationLevel.Anonymous,
            "get",
            Route = "getByName")]
        HttpRequestData req)
        {
            var response = req.CreateResponse();
            BrregCaller brregCaller = new BrregCaller();
            string orgName = req.Query["name"];

            List<BrregJSONReply> brregJSONReply = await brregCaller.getOrgsByName(orgName);

            await response.WriteAsJsonAsync(brregJSONReply);

            return response;
        }

    }
}
