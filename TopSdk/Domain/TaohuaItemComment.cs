using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaItemComment Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaItemComment : TopObject
    {
        /// <summary>
        /// 商品评论的具体内容
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 评论发表时间
        /// </summary>
        [XmlElement("comment_date")]
        public string CommentDate { get; set; }

        /// <summary>
        /// 评论人
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
