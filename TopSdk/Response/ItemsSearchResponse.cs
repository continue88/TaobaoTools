using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemsSearchResponse.
    /// </summary>
    public class ItemsSearchResponse : TopResponse
    {
        /// <summary>
        /// 搜索到的商品，具体字段根据权限和设定的fields决定
        /// </summary>
        [XmlElement("item_search")]
        public ItemSearch ItemSearch { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
