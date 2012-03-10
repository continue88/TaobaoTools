using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaAudioreaderRecommendGetResponse.
    /// </summary>
    public class TaohuaAudioreaderRecommendGetResponse : TopResponse
    {
        /// <summary>
        /// 有声读物专辑摘要列表
        /// </summary>
        [XmlArray("audioreader_summaries")]
        [XmlArrayItem("taohua_audio_reader_album_summary")]
        public List<TaohuaAudioReaderAlbumSummary> AudioreaderSummaries { get; set; }

        /// <summary>
        /// 符合条件的专辑总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
