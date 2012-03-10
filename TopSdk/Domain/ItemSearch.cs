using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemSearch Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSearch : TopObject
    {
        /// <summary>
        /// 商品搜索分类
        /// </summary>
        [XmlArray("item_categories")]
        [XmlArrayItem("item_category")]
        public List<ItemCategory> ItemCategories { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("item")]
        public List<Item> Items { get; set; }
    }
}
