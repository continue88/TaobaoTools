using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// HuabaoAuctionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HuabaoAuctionInfo : TopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("auction_id")]
        public long AuctionId { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("auction_note")]
        public string AuctionNote { get; set; }

        /// <summary>
        /// 商品位置坐标,形式为："x:y",x坐标,y坐标
        /// </summary>
        [XmlElement("auction_position")]
        public string AuctionPosition { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("auction_price")]
        public string AuctionPrice { get; set; }

        /// <summary>
        /// 商品短标题
        /// </summary>
        [XmlElement("auction_short_title")]
        public string AuctionShortTitle { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("auction_title")]
        public string AuctionTitle { get; set; }

        /// <summary>
        /// 商品链接
        /// </summary>
        [XmlElement("auction_url")]
        public string AuctionUrl { get; set; }

        /// <summary>
        /// 商品图片ID
        /// </summary>
        [XmlElement("pic_id")]
        public long PicId { get; set; }

        /// <summary>
        /// 画报ID
        /// </summary>
        [XmlElement("poster_id")]
        public long PosterId { get; set; }
    }
}
