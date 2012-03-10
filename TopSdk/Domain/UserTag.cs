using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// UserTag Data Structure.
    /// </summary>
    [Serializable]
    public class UserTag : TopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        [XmlElement("tag_id")]
        public long TagId { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
