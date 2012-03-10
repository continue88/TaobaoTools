using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemCat Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCat : TopObject
    {
        /// <summary>
        /// 商品所属类目ID
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 该类目是否为父类目(即：该类目是否还有子类目)
        /// </summary>
        [XmlElement("is_parent")]
        public bool IsParent { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父类目ID=0时，代表的是一级的类目
        /// </summary>
        [XmlElement("parent_cid")]
        public long ParentCid { get; set; }

        /// <summary>
        /// 排列序号，表示同级类目的展现次序，如数值相等则按名称次序排列。取值范围:大于零的整数
        /// </summary>
        [XmlElement("sort_order")]
        public long SortOrder { get; set; }

        /// <summary>
        /// 状态。可选值:normal(正常),deleted(删除)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
