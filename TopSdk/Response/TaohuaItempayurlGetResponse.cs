using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaItempayurlGetResponse.
    /// </summary>
    public class TaohuaItempayurlGetResponse : TopResponse
    {
        /// <summary>
        /// 支付URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
