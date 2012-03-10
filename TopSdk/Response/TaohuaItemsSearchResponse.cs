using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaItemsSearchResponse.
    /// </summary>
    public class TaohuaItemsSearchResponse : TopResponse
    {
        /// <summary>
        /// 商品搜索列表数据结构
        /// </summary>
        [XmlElement("search_items_result")]
        public TaohuaSearchItems SearchItemsResult { get; set; }
    }
}
