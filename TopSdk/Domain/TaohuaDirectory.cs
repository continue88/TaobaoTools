using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaDirectory Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaDirectory : TopObject
    {
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

        /// <summary>
        /// 子类目类型
        /// </summary>
        [XmlElement("rel")]
        public string Rel { get; set; }
    }
}
