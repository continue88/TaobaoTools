using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HuabaoChannelsGetResponse.
    /// </summary>
    public class HuabaoChannelsGetResponse : TopResponse
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("poster_channel")]
        public List<PosterChannel> Channels { get; set; }
    }
}
