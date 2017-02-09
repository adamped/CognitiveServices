namespace CognitiveServices.DTO.LUIS
{
    public class Prediction
    {

        public string query { get; set; }

    }

    public class Intent
    {
        public string intent { get; set; }

        public double score { get; set; }
    }

}
