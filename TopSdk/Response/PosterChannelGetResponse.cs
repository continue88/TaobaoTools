using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PosterChannelGetResponse.
    /// </summary>
    public class PosterChannelGetResponse : TopResponse
    {
        /// <summary>
        /// 频道信息
        /// </summary>
        [XmlElement("channel")]
        public HuabaoChannel Channel { get; set; }
    }
}
