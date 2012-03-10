using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaCateStat Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaCateStat : TopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("cate_id")]
        public long CateId { get; set; }

        /// <summary>
        /// 当前类目下面的商品数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
