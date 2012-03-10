using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// HuabaoChannel Data Structure.
    /// </summary>
    [Serializable]
    public class HuabaoChannel : TopObject
    {
        /// <summary>
        /// 频道名称
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 淘宝频道连接
        /// </summary>
        [XmlElement("channel_url")]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// 频道描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 画报频道ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 频道英文名称
        /// </summary>
        [XmlElement("name_en")]
        public string NameEn { get; set; }
    }
}
