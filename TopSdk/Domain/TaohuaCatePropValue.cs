using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaCatePropValue Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaCatePropValue : TopObject
    {
        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("prop_value")]
        public string PropValue { get; set; }

        /// <summary>
        /// 属性值id
        /// </summary>
        [XmlElement("value_id")]
        public long ValueId { get; set; }
    }
}
