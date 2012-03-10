using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaRootDirectory Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaRootDirectory : TopObject
    {
        /// <summary>
        /// 子目录
        /// </summary>
        [XmlArray("kids")]
        [XmlArrayItem("taohua_directory")]
        public List<TaohuaDirectory> Kids { get; set; }

        /// <summary>
        /// 目录名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }
    }
}
