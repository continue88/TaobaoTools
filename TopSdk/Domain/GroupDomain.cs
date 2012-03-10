using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// GroupDomain Data Structure.
    /// </summary>
    [Serializable]
    public class GroupDomain : TopObject
    {
        /// <summary>
        /// 分组ID
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
