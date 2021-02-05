using System;
using System.Globalization;
using System.Text.Json.Serialization;

namespace take_test.Domain.Model
{
    public class RepositoryModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("pushed_at")]
        public string JsonDate { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        public DateTime Created_at =>
            DateTime.ParseExact(JsonDate, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
    }
}
