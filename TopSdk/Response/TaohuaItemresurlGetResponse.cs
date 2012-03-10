using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaItemresurlGetResponse.
    /// </summary>
    public class TaohuaItemresurlGetResponse : TopResponse
    {
        /// <summary>
        /// 下载链接地址.
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
