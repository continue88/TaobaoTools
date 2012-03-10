using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaAudioReaderAlbum Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaAudioReaderAlbum : TopObject
    {
        /// <summary>
        /// 播音员名称
        /// </summary>
        [XmlElement("artist_name")]
        public string ArtistName { get; set; }

        /// <summary>
        /// 码流
        /// </summary>
        [XmlElement("bit_rate")]
        public string BitRate { get; set; }

        /// <summary>
        /// 版权所属
        /// </summary>
        [XmlElement("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// 专辑简介
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 时长
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 格式
        /// </summary>
        [XmlElement("format")]
        public string Format { get; set; }

        /// <summary>
        /// 专辑ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 专辑最后更新日期
        /// </summary>
        [XmlElement("last_updated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// 专辑封面图片url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

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
        /// 集数
        /// </summary>
        [XmlElement("track_count")]
        public long TrackCount { get; set; }
    }
}
