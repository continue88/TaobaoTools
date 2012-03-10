using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaItemCommentResult Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaItemCommentResult : TopObject
    {
        /// <summary>
        /// 淘花商品评论列表
        /// </summary>
        [XmlArray("taohua_item_comments")]
        [XmlArrayItem("taohua_item_comment")]
        public List<TaohuaItemComment> TaohuaItemComments { get; set; }

        /// <summary>
        /// 评论总数
        /// </summary>
        [XmlElement("total_comment_num")]
        public long TotalCommentNum { get; set; }
    }
}
