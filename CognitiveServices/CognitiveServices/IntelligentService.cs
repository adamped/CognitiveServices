using System;
using System.Collections.Generic;
using System.Linq;
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
        public IntelligentService(Config config)
        {
            _config = config;            
        }

    }
}
