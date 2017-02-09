using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveServices
{
    /// <summary>
    /// LUIS: Language Understanding Intelligent Service
    /// https://azure.microsoft.com/en-us/services/cognitive-services/language-understanding-intelligent-service/
    /// </summary>
    public class IntelligentService
    {
        private Config _config;
        private string _appId;
        public IntelligentService(string appId, Config config)
        {
            _appId = appId;
            _config = config;
        }

        public async Task Resolve(string text)
        {
            var client = new HttpClient();

            var uri = $"{_config.LUIS.APIEndpoint}/apps/{_appId}?subscription-key={_config.LUIS.APIKey}&q={System.Web.HttpUtility.UrlEncode(text)}&verbose=true";

            var response = await client.GetAsync(uri);

            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }

    }
}
