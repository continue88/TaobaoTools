using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// MarketingTagsGetResponse.
    /// </summary>
    public class MarketingTagsGetResponse : TopResponse
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("user_tags")]
        [XmlArrayItem("user_tag")]
        public List<UserTag> UserTags { get; set; }
    }
}
