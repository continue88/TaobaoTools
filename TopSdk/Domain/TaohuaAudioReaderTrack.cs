using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaAudioReaderTrack Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaAudioReaderTrack : TopObject
    {
        /// <summary>
        /// 单曲时长
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 单曲ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 单曲更新日期
        /// </summary>
        [XmlElement("last_updated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// 单曲价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 单曲名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
