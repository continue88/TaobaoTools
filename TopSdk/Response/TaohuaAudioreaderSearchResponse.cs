using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaAudioreaderSearchResponse.
    /// </summary>
    public class TaohuaAudioreaderSearchResponse : TopResponse
    {
        /// <summary>
        /// 有声读物专辑摘要列表
        /// </summary>
        [XmlArray("audioreader_search_results")]
        [XmlArrayItem("taohua_audio_reader_album_summary")]
        public List<TaohuaAudioReaderAlbumSummary> AudioreaderSearchResults { get; set; }

        /// <summary>
        /// 搜索返回的专辑总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
