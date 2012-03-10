using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaUpdateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaUpdateInfo : TopObject
    {
        /// <summary>
        /// 提示消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 最新下载地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }
    }
}
