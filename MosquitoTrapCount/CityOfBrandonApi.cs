using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace MosquitoTrapCount.PCL
{
    public static class CityOfBrandonApi
    {
       
        public static async Task<IEnumerable<TrapCountRecord>> GetAll2015()
        {

            var results = new List<TrapCountRecord>();
            using (var webclient = new HttpClient())
            {
                var url = new Uri("http://opengov.brandon.ca/opendataservice/Default.aspx?dataset=mosquito_counts&format=json&columns=Sampling%20Dates"); 
                var json = await webclient.GetStringAsync(url);

                var tokens = JArray.Parse(json);

                foreach (var token in tokens)
                {
                    results.Add(new TrapCountRecord(){ 
                        SamplingDate = (DateTime)token["Sampling Dates"],
                        DailyAvgCount = (int)token["Daily Average Count"],
                        Trap1 = (int)token["Trap 1<br/>Parks Office"],
                        Trap2 = (int)token["Trap 2<br/>Canada Crescent"],
                        Trap3 = (int)token["Trap 3<br/>BU Gym"],
                        Trap4 = (int)token["Trap 4<br/>Civic Services Complex"],
                        Trap5 = (int)token["Trap 5<br/>Municipal Cemetery"]
                    });
                }

                return results.OrderByDescending(x=>x.SamplingDate);
               
            }
        }

        public static async Task<IEnumerable<TrapCountRecord>> GetHistorical()
        {

            var results = new List<TrapCountRecord>();
            using (var webclient = new HttpClient())
            {
                var url = new Uri("http://opengov.brandon.ca/opendataservice/Default.aspx?dataset=mosquito_counts_historical&format=json&columns=Sampling%20Dates&limit=1000"); 
                var json = await webclient.GetStringAsync(url);

                var tokens = JArray.Parse(json);

                foreach (var token in tokens)
                {
                    results.Add(new TrapCountRecord(){ 
                        SamplingDate = (DateTime)token["Sampling Dates"],
                        DailyAvgCount = (int)token["Daily Average Count"],
                        Trap1 = (int)token["Trap 1"],
                        Trap2 = (int)token["Trap 2"],
                        Trap3 = (int)token["Trap 3"],
                        Trap4 = (int)token["Trap 4"],
                        Trap5 = (int)token["Trap 5"]
                    });
                }

                return results.OrderByDescending(x=>x.SamplingDate);

            }
        }
    }
}

