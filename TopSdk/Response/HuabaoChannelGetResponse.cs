using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HuabaoChannelGetResponse.
    /// </summary>
    public class HuabaoChannelGetResponse : TopResponse
    {
        /// <summary>
        /// 频道信息
        /// </summary>
        [XmlElement("channel")]
        public PosterChannel Channel { get; set; }
    }
}
