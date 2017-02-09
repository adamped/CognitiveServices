using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveServices
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Rename config.json.template to config.json and enter the appropriate configuration.

            var configFile = string.Empty;

            using (StreamReader sr = new StreamReader("config.json"))
                configFile = sr.ReadToEnd();

            var config = JsonConvert.DeserializeObject<Config>(configFile);

            // TODO: Enter your appId here

            var appId = "";

            var luis = new IntelligentService(appId, config);

            luis.Resolve("Open passenger door").Wait();

            Console.WriteLine("Program end. Press enter to exit.");
            Console.ReadLine();
        }
    }
}
