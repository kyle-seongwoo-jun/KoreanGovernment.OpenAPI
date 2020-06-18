using System.Linq;
using System.Threading.Tasks;
using KoreanGovernment.OpenAPI.Health.Corona19Mask;
using static System.Console;

namespace KoreanGovernment.OpenAPI.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var stores = await Corona19Mask.StoresByAddressAsync("서울특별시 강남구");
            foreach (var store in stores.Take(10))
            {
                WriteLine(store);
            }
        }
    }
}
