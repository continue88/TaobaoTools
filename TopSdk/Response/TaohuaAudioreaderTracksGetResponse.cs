using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaAudioreaderTracksGetResponse.
    /// </summary>
    public class TaohuaAudioreaderTracksGetResponse : TopResponse
    {
        /// <summary>
        /// 有声读物单曲列表
        /// </summary>
        [XmlArray("audioreader_tracks")]
        [XmlArrayItem("taohua_audio_reader_track")]
        public List<TaohuaAudioReaderTrack> AudioreaderTracks { get; set; }

        /// <summary>
        /// 专辑内的单曲总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
