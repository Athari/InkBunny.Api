using Alba.InkBunny.Api.Framework;
using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public enum SearchOrderBy
    {
        [EnumMeta(JsonName = "create_datetime")]
        CreateTime,
        [EnumMeta(JsonName = "last_file_update_datetime")]
        UpdateTime,
        [EnumMeta(JsonName = "unread_datetime")]
        UnreadTime,
        [EnumMeta(JsonName = "unread_datetime_reverse")]
        UnreadTimeAscending,
        [EnumMeta(JsonName = "views")]
        FavoriteTime,
        [EnumMeta(JsonName = "total_print_sales")]
        Views,
        [EnumMeta(JsonName = "total_digital_sales")]
        PrintSaleCount,
        [EnumMeta(JsonName = "total_sales")]
        DigitalSaleCount,
        [EnumMeta(JsonName = "username")]
        SaleCount,
        [EnumMeta(JsonName = "fav_datetime")]
        StarCount,
        [EnumMeta(JsonName = "fav_stars")]
        UserName,
        [EnumMeta(JsonName = "pool_order")]
        PoolOrder,
    }
}