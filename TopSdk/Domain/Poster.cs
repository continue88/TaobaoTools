using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Poster Data Structure.
    /// </summary>
    [Serializable]
    public class Poster : TopObject
    {
        /// <summary>
        /// 画报所属频道id。
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 封面路径。由逗号(',')分开，最多2个
        /// </summary>
        [XmlElement("cover_urls")]
        public string CoverUrls { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 画报的点击总数。
        /// </summary>
        [XmlElement("hits")]
        public long Hits { get; set; }

        /// <summary>
        /// 画报ID。
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 图片短标题。
        /// </summary>
        [XmlElement("short_title")]
        public string ShortTitle { get; set; }

        /// <summary>
        /// 画报相关标签，由逗号(',')分开，最多5个。
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 图片标题。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 权重。-1 至 10 。10为最高。
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }
    }
}
