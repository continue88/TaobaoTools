using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaAudioReaderMyAlbum Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaAudioReaderMyAlbum : TopObject
    {
        /// <summary>
        /// 版权所属
        /// </summary>
        [XmlElement("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// 专辑ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 最后更新日期
        /// </summary>
        [XmlElement("last_updated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// 专辑内已购买的单曲总数
        /// </summary>
        [XmlElement("my_track_count")]
        public long MyTrackCount { get; set; }

        /// <summary>
        /// 专辑封面图片url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 购买专辑的序列ID
        /// </summary>
        [XmlElement("serial_id")]
        public long SerialId { get; set; }

        /// <summary>
        /// 专辑状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 专辑名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 专辑内的单曲总数
        /// </summary>
        [XmlElement("track_count")]
        public long TrackCount { get; set; }
    }
}
