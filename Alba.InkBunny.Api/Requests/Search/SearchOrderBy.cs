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
        [EnumMeta(JsonName = "fav_datetime")]
        FavoriteTime,
        [EnumMeta(JsonName = "views")]
        Views,
        [EnumMeta(JsonName = "total_print_sales")]
        PrintSaleCount,
        [EnumMeta(JsonName = "total_digital_sales")]
        DigitalSaleCount,
        [EnumMeta(JsonName = "total_sales")]
        SaleCount,
        [EnumMeta(JsonName = "fav_stars")]
        StarCount,
        [EnumMeta(JsonName = "username")]
        UserName,
        [EnumMeta(JsonName = "pool_order")]
        PoolOrder,
    }
}