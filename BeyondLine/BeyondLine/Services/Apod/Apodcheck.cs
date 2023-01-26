using System;
using System.Collections.Generic;
using System.Text;
using Apod;
using System.Threading.Tasks;


namespace BeyondLine.Apod
{
    class Apodcheck
    {
        static string api_key = "92q8cw5k6SWV3BImSmJDgcMc5w7aWdeUxwZHHHgZ";

        static Data data;

        public static async Task Main()
        {
            
            using var client = new ApodClient(api_key);
            var response = await client.FetchApodAsync();

            if (response.StatusCode != ApodStatusCode.OK)
            {
                Console.WriteLine(response.Error.ErrorCode);
                Console.WriteLine(response.Error.ErrorMessage);
                return;
            }

            var apod = response.Content;
            //data = new Data(apod.Title,apod.Date,apod.ContentUrl,apod.Explanation);
            /*Console.WriteLine(apod.Title);
            Console.WriteLine(apod.ContentUrl);
            Console.WriteLine(apod.Explanation);*/

            foreach (var a in response.AllContent)
            {
                var formattedDate = apod.Date.ToString("MMMM d, yyyy");
                Console.WriteLine($"{formattedDate}: \"{apod.Title}\".");
            }
            //client.Dispose();
        }

        public Data GetData()
        {
            return data;
        }
    }
}
