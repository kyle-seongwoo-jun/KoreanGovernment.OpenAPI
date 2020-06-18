using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KoreanGovernment.OpenAPI.Health.Corona19Mask
{
    internal class StockStatConverter : JsonConverter<StockStat?>
    {
        public override StockStat? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() switch
            {
                "plenty" => StockStat.Plenty,
                "some" => StockStat.Some,
                "few" => StockStat.Few,
                "empty" => StockStat.Empty,
                "break" => StockStat.Break,
                _ => null
            };
        }

        public override void Write(Utf8JsonWriter writer, StockStat? value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
