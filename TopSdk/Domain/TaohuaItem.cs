using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaItem Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaItem : TopObject
    {
        /// <summary>
        /// 描述图书作者信息
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 描述用户喜欢值
        /// </summary>
        [XmlElement("favorite")]
        public long Favorite { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 叶子类目的ID
        /// </summary>
        [XmlElement("leaf_cate_id")]
        public long LeafCateId { get; set; }

        /// <summary>
        /// 叶子类目的名称
        /// </summary>
        [XmlElement("leaf_cate_name")]
        public string LeafCateName { get; set; }

        /// <summary>
        /// 商品图片链接
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品价格属性
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 描述出版日期
        /// </summary>
        [XmlElement("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 描述商品出版社属性
        /// </summary>
        [XmlElement("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// 根类目ID
        /// </summary>
        [XmlElement("root_cate_id")]
        public long RootCateId { get; set; }

        /// <summary>
        /// 根类目名称
        /// </summary>
        [XmlElement("root_cate_name")]
        public string RootCateName { get; set; }

        /// <summary>
        /// 文件大小，单位byte
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 从未上架 never_put_shelves,  上架put_shelves,  小二下架down_shevles,  删除delete,  用户下架down_shevles_by_seller
        /// </summary>
        [XmlElement("status_name")]
        public string StatusName { get; set; }

        /// <summary>
        /// 淘花商品的属性值对数据结构
        /// </summary>
        [XmlArray("taohua_item_pv_pairs")]
        [XmlArrayItem("taohua_item_p_v_pair")]
        public List<TaohuaItemPVPair> TaohuaItemPvPairs { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
