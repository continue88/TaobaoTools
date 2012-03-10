using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaPreviewurlGetResponse.
    /// </summary>
    public class TaohuaPreviewurlGetResponse : TopResponse
    {
        /// <summary>
        /// 预览链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
