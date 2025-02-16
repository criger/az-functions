using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class BrregCaller
{
       
    public async Task<BrregJSONReply> getData(string orgId)
    {
        var client = new HttpClient(new HttpClientHandler());

        client.BaseAddress = new Uri("https://data.brreg.no");

        var content = await client.GetStringAsync("/enhetsregisteret/api/enheter/" + orgId);

        var jsonReply = JsonConvert.DeserializeObject<BrregJSONReply>(content.ToString());

        return jsonReply;
    }

    public async Task<List<BrregJSONReply>> getOrgsByName(string orgNavn)
    {
        var client = new HttpClient(new HttpClientHandler());

        client.BaseAddress = new Uri("https://data.brreg.no");

        var content = await client.GetStringAsync("/enhetsregisteret/api/enheter?navn=" + orgNavn);

        var jsonReply = JsonConvert.DeserializeObject<JObject>(content.ToString());
        var jsonList = jsonReply.Value<JObject>("_embedded").Value<JArray>("enheter").ToObject<List<BrregJSONReply>>();

        return jsonList;
    }


}
