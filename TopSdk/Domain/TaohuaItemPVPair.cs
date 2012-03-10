using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaItemPVPair Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaItemPVPair : TopObject
    {
        /// <summary>
        /// 淘花类目属性数据结构
        /// </summary>
        [XmlElement("taohua_cate_prop")]
        public TaohuaCateProp TaohuaCateProp { get; set; }

        /// <summary>
        /// 淘花类目属性值数据结构
        /// </summary>
        [XmlArray("taohua_cate_prop_values")]
        [XmlArrayItem("taohua_cate_prop_value")]
        public List<TaohuaCatePropValue> TaohuaCatePropValues { get; set; }
    }
}
