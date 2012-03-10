using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaAudioReaderAlbumSummary Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaAudioReaderAlbumSummary : TopObject
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
        /// 商品状态
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
