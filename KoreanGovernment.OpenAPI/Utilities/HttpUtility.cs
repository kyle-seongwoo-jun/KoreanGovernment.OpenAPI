namespace KoreanGovernment.OpenAPI.Utilities
{
    internal static class HttpUtility
    {
        public static string UrlEncode(this string text) => System.Web.HttpUtility.UrlEncode(text);
    }
}
