using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Huabao Data Structure.
    /// </summary>
    [Serializable]
    public class Huabao : TopObject
    {
        /// <summary>
        /// 画报所属频道ID
        /// </summary>
        [XmlElement("channel_id")]
        public long ChannelId { get; set; }

        /// <summary>
        /// 画报封面地址
        /// </summary>
        [XmlElement("cover_pic_url")]
        public string CoverPicUrl { get; set; }

        /// <summary>
        /// 画报创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 画报点击数
        /// </summary>
        [XmlElement("hits")]
        public long Hits { get; set; }

        /// <summary>
        /// 画报ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 画报修改时间
        /// </summary>
        [XmlElement("modified_date")]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 画报标签
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 图片标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 画报短标题
        /// </summary>
        [XmlElement("title_short")]
        public string TitleShort { get; set; }

        /// <summary>
        /// 画报权重0-10
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }
    }
}
