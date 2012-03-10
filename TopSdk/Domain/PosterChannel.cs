using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PosterChannel Data Structure.
    /// </summary>
    [Serializable]
    public class PosterChannel : TopObject
    {
        /// <summary>
        /// 频道的中文名称。
        /// </summary>
        [XmlElement("cn_name")]
        public string CnName { get; set; }

        /// <summary>
        /// 频道的说明。
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 频道ID号。
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 频道名称。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 淘宝频道链接地址。
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 手机画报对应频道页的链接
        /// </summary>
        [XmlElement("wapurl")]
        public string Wapurl { get; set; }
    }
}
