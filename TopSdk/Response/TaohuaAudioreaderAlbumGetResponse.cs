using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaAudioreaderAlbumGetResponse.
    /// </summary>
    public class TaohuaAudioreaderAlbumGetResponse : TopResponse
    {
        /// <summary>
        /// 有声读物专辑
        /// </summary>
        [XmlElement("audioreader_album")]
        public TaohuaAudioReaderAlbum AudioreaderAlbum { get; set; }
    }
}
