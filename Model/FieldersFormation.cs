using Newtonsoft.Json;

namespace CricketFieldLogger.Helper
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FieldersFormation
    {
        public int fielderId { get; set; }
        public int leftLocation { get; set; }
        public int topLocation { get; set; }

        public FieldersFormation(int fielderId, int leftLocation, int topLocation)
        {
            this.leftLocation = leftLocation;
            this.topLocation = topLocation;
            this.fielderId = fielderId;
        }
    }
}
