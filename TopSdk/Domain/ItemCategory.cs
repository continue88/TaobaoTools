using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemCategory Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCategory : TopObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
