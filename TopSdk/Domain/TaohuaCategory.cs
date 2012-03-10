using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaCategory Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaCategory : TopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("cate_id")]
        public long CateId { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [XmlElement("cate_level")]
        public long CateLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父类目ID
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [XmlElement("sort_order")]
        public long SortOrder { get; set; }
    }
}
