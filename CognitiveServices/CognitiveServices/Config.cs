namespace CognitiveServices
{
    public class Config
    {

        public LUIS LUIS { get; set; }

    }

    public class LUIS
    {
        public string APIKey { get; set; }
        public string APIEndpoint { get; set; }
    }

}
