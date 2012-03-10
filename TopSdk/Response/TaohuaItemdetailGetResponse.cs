using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaItemdetailGetResponse.
    /// </summary>
    public class TaohuaItemdetailGetResponse : TopResponse
    {
        /// <summary>
        /// 淘花商品数据结构
        /// </summary>
        [XmlElement("taohua_item_detail")]
        public TaohuaItem TaohuaItemDetail { get; set; }
    }
}
