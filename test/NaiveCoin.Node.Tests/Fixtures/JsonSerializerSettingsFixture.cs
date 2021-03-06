using Newtonsoft.Json;

namespace NaiveCoin.Tests.Fixtures
{
    public class JsonSerializerSettingsFixture
    {
        public JsonSerializerSettingsFixture()
        {
            Value = new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        public JsonSerializerSettings Value { get; set; }
    }
}