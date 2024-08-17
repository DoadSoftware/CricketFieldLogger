using System.Collections.Generic;
using Newtonsoft.Json;

namespace CricketFieldLogger.Helper
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FieldersFormation
    {
      
        [JsonProperty("fielderId")]
        public int fielderId { get; set; }
        [JsonProperty("leftLocation")]
        public int leftLocation { get; set; }
        [JsonProperty("topLocation")]
        public int topLocation { get; set; }

        [JsonProperty("fielderhighlight")]
        public string fielderhighlight { get; set; }

        public FieldersFormation(int fielderId, int leftLocation, int topLocation, string fielderhighlight)
        {
            this.leftLocation = leftLocation;
            this.topLocation = topLocation;
            this.fielderId = fielderId;
            this.fielderhighlight = fielderhighlight;
;
        }
    }
   


    public class FieldersData
    {
        [JsonProperty("Checkbox")]
        public bool Checkbox { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("BowlingEnd")]
        public string BowlingEnd { get; set; }

        [JsonProperty("fielders")]
        public List<FieldersFormation> Fielders { get; set; }

        public FieldersData(bool checkbox,string style, List<FieldersFormation> fielders)
        {
            Checkbox = checkbox;
            Fielders = fielders;
            Style = style;
        }
    
    }
}
