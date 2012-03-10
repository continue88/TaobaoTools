using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaChildcatesGetResponse.
    /// </summary>
    public class TaohuaChildcatesGetResponse : TopResponse
    {
        /// <summary>
        /// 淘花类目数据结构
        /// </summary>
        [XmlArray("taohua_categories")]
        [XmlArrayItem("taohua_category")]
        public List<TaohuaCategory> TaohuaCategories { get; set; }

        /// <summary>
        /// 总类目数
        /// </summary>
        [XmlElement("total_cates")]
        public long TotalCates { get; set; }
    }
}
