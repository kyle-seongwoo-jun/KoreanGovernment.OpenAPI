using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KoreanGovernment.OpenAPI.Health.Corona19Mask
{
    internal class DateTimeOffsetConverter : JsonConverter<DateTimeOffset?>
    {
        public override DateTimeOffset? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? datetime = reader.GetString();
            if (datetime == null) return null;

            return DateTimeOffset.ParseExact(datetime, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset? value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
