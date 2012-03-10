using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaSearchItem Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaSearchItem : TopObject
    {
        /// <summary>
        /// 描述图书作者
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 文档总页数
        /// </summary>
        [XmlElement("doc_pages")]
        public long DocPages { get; set; }

        /// <summary>
        /// 描述用户对某一商品的喜欢程度，值越大，则表示越喜欢
        /// </summary>
        [XmlElement("favorite")]
        public long Favorite { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 商品图片链接
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品价格，单位：分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 描述图书出版日期
        /// </summary>
        [XmlElement("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 描述商品的出版社信息
        /// </summary>
        [XmlElement("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// 根类目ID
        /// </summary>
        [XmlElement("root_cate_id")]
        public long RootCateId { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [XmlElement("sell_count")]
        public long SellCount { get; set; }

        /// <summary>
        /// 淘花卖家的编号，注意：不是淘宝会员的编号。
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 卖家的淘宝nick
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 商品所属店铺名称
        /// </summary>
        [XmlElement("shop_title")]
        public string ShopTitle { get; set; }

        /// <summary>
        /// 文件大小，单位:byte
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 文档后缀名
        /// </summary>
        [XmlElement("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 二级类目的名称
        /// </summary>
        [XmlElement("two_level_name")]
        public string TwoLevelName { get; set; }

        /// <summary>
        /// 浏览量
        /// </summary>
        [XmlElement("view_count")]
        public long ViewCount { get; set; }
    }
}
