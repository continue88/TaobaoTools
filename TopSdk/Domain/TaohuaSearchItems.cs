using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaSearchItems Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaSearchItems : TopObject
    {
        /// <summary>
        /// 淘花类目路径数据结构
        /// </summary>
        [XmlArray("cate_paths")]
        [XmlArrayItem("taohua_category")]
        public List<TaohuaCategory> CatePaths { get; set; }

        /// <summary>
        /// 搜索引擎根据搜索条件中的上一级类目统计出的子类目列表
        /// </summary>
        [XmlArray("cate_stats")]
        [XmlArrayItem("taohua_cate_stat")]
        public List<TaohuaCateStat> CateStats { get; set; }

        /// <summary>
        /// 淘花搜索商品对象列表数据结构
        /// </summary>
        [XmlArray("taohua_search_items")]
        [XmlArrayItem("taohua_search_item")]
        public List<TaohuaSearchItem> TaohuaSearchItems_ { get; set; }

        /// <summary>
        /// 搜索出来的商品总数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
