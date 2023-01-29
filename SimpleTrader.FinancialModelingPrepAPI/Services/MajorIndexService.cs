using Newtonsoft.Json;
using SimpleTrader.Domain.Model;
using SimpleTrader.Domain.Service;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleTrader.FinancialModelingPrepAPI.Services
{
  public class MajorIndexService : IMajorIndexService
  {
    public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
    {
      using(HttpClient client = new HttpClient())
      {
        HttpResponseMessage responce =  await client.GetAsync($"https://financialmodelingprep.com/api/v3/profile/{indexType}?apikey=f0be9412866c53dc0c71c289db46a001");
        string jsonresponse = await responce.Content.ReadAsStringAsync();


        MajorIndex majorIndex = JsonConvert.DeserializeObject<MajorIndex>(jsonresponse.Substring(1, jsonresponse.Length - 2));
        string jsonresponses = await responce.Content.ReadAsStringAsync();
        return majorIndex;
      }
    }
  }
}
