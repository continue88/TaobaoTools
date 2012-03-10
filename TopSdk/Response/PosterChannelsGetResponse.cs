using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PosterChannelsGetResponse.
    /// </summary>
    public class PosterChannelsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回频道列表
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("huabao_channel")]
        public List<HuabaoChannel> Channels { get; set; }
    }
}
