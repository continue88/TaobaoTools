using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaAudioreaderTrackDownloadurlGetResponse.
    /// </summary>
    public class TaohuaAudioreaderTrackDownloadurlGetResponse : TopResponse
    {
        /// <summary>
        /// 有声读物单曲下载地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
