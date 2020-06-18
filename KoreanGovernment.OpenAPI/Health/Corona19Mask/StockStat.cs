namespace KoreanGovernment.OpenAPI.Health.Corona19Mask
{
    /// <summary>
    /// 재고 상태
    /// </summary>
    public enum StockStat
    {
        /// <summary>
        /// 100개 이상 (녹색)
        /// </summary>
        Plenty,

        /// <summary>
        /// 30개 이상 100개미만 (노랑색)
        /// </summary>
        Some,

        /// <summary>
        /// 2개 이상 30개 미만 (빨강색)
        /// </summary>
        Few,

        /// <summary>
        /// 1개 이하 (회색)
        /// </summary>
        Empty,

        /// <summary>
        /// 판매중지
        /// </summary>
        Break
    }
}
