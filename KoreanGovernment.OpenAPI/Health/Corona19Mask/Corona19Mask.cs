using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using KoreanGovernment.OpenAPI.Utilities;

namespace KoreanGovernment.OpenAPI.Health.Corona19Mask
{
    /// <summary>
    /// 공적 마스크 판매 현황 조회 API
    /// https://app.swaggerhub.com/apis-docs/Promptech/public-mask-info/20200307-oas3
    /// </summary>
    public class Corona19Mask
    {
        /// <summary>
        /// 주소를 기준으로 해당 구 또는 동내에 존재하는 판매처 및 재고 상태 등의 판매 정보 제공.
        /// 예- '서울특별시 강남구' or '서울특별시 강남구 논현동'
        /// ('서울특별시' 와 같이 '시'단위만 입력하는 것은 불가능합니다.)
        /// </summary>
        /// <param name="address">검색 기준이 될 주소</param>
        /// <param name="cancellationToken">A token that may ne used to cancel the read operatioorona19Mask
        /// <returns></returns>
        public static async Task<Store[]> StoresByAddressAsync(string address, CancellationToken cancellationToken = default)
        {
            string url = $"https://8oi9s0nnth.apigw.ntruss.com/corona19-masks/v1/storesByAddr/json?address={address.UrlEncode()}";

            // request
            using var client = new HttpClient();
            using var response = await client.GetAsync(url).ConfigureAwait(false);

            // when request failed
            if (!response.IsSuccessStatusCode)
            {
                return Array.Empty<Store>();
            }

            // parse
            await using var stream = await response.Content.ReadAsStreamAsync();
            var res = await JsonSerializer.DeserializeAsync<Response>(stream, cancellationToken: cancellationToken);

            return res.Stores;
        }
    }
}
