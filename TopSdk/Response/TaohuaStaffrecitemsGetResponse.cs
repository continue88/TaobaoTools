using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaStaffrecitemsGetResponse.
    /// </summary>
    public class TaohuaStaffrecitemsGetResponse : TopResponse
    {
        /// <summary>
        /// 淘花商品数据结构列表
        /// </summary>
        [XmlArray("taohua_items")]
        [XmlArrayItem("taohua_item")]
        public List<TaohuaItem> TaohuaItems { get; set; }

        /// <summary>
        /// 总商品数量
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }
    }
}
