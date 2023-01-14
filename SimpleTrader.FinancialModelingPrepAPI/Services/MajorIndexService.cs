using SimpleTrader.Domain.Model;
using SimpleTrader.Domain.Service;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.FinancialModelingPrepAPI.Services
{
  public class MajorIndexService : IMajorIndexService
  {
    public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
    {
      using(HttpClient client = new HttpClient())
      {
        await client.GetAsync("https://financialmodelingprep.com/api/v3/nasdaq_constituent?apikey=YOUR_API_KEY")
      }
    }
  }
}
