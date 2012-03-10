using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaCateProp Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaCateProp : TopObject
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性结构
        /// </summary>
        [XmlElement("prop_id")]
        public long PropId { get; set; }
    }
}
