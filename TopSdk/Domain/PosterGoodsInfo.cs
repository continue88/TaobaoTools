using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PosterGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PosterGoodsInfo : TopObject
    {
        /// <summary>
        /// 商品描述信息
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("num_id")]
        public long NumId { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [XmlElement("pic_id")]
        public long PicId { get; set; }

        /// <summary>
        /// 画报id
        /// </summary>
        [XmlElement("poster_id")]
        public long PosterId { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品短标题
        /// </summary>
        [XmlElement("short_title")]
        public string ShortTitle { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 手机上相应购买地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
