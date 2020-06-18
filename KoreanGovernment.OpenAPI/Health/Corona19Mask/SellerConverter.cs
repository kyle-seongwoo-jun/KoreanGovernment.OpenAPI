using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KoreanGovernment.OpenAPI.Health.Corona19Mask
{
    internal class SellerConverter : JsonConverter<Seller>
    {
        public override Seller Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() switch
            {
                "01" => Seller.Pharmacy,
                "02" => Seller.PostOffice,
                "03" => Seller.NH,
                _ => throw new NotImplementedException()
            };
        }

        public override void Write(Utf8JsonWriter writer, Seller value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
