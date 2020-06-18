using System;
using System.Text.Json.Serialization;

namespace KoreanGovernment.OpenAPI.Health.Corona19Mask
{
    public class Store
    {
        /// <summary>
        /// 식별 코드
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 이름
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 주소
        /// </summary>
        [JsonPropertyName("addr")]
        public string Address { get; set; }

        /// <summary>
        /// 판매처 유형
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(SellerConverter))]
        public Seller Type { get; set; }

        /// <summary>
        /// 위도
        /// </summary>
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// 경도
        /// </summary>
        [JsonPropertyName("lng")]
        public double Lng { get; set; }

        /// <summary>
        /// 입고시간
        /// </summary>
        [JsonPropertyName("stock_at")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset? StockAt { get; set; }

        /// <summary>
        /// 재고 상태
        /// </summary>
        [JsonPropertyName("remain_stat")]
        [JsonConverter(typeof(StockStatConverter))]
        public StockStat? RemainStat { get; set; }

        /// <summary>
        /// 데이터 생성 일자
        /// </summary>
        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset? CreatedAt { get; set; }

        public override string ToString()
        {
            return $"[{Code}] {Name} - {Address}";
        }
    }
}
