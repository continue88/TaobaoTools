using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaAudioreaderMytracksGetResponse.
    /// </summary>
    public class TaohuaAudioreaderMytracksGetResponse : TopResponse
    {
        /// <summary>
        /// 我的有声书库单曲列表
        /// </summary>
        [XmlArray("my_audioreader_tracks")]
        [XmlArrayItem("taohua_audio_reader_track")]
        public List<TaohuaAudioReaderTrack> MyAudioreaderTracks { get; set; }

        /// <summary>
        /// 我的有声书库单曲数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
