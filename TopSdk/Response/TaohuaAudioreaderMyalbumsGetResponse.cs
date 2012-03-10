using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaAudioreaderMyalbumsGetResponse.
    /// </summary>
    public class TaohuaAudioreaderMyalbumsGetResponse : TopResponse
    {
        /// <summary>
        /// 我的有声书库专辑列表
        /// </summary>
        [XmlArray("my_audioreader_albums")]
        [XmlArrayItem("taohua_audio_reader_my_album")]
        public List<TaohuaAudioReaderMyAlbum> MyAudioreaderAlbums { get; set; }

        /// <summary>
        /// 我的有声书库专辑数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
