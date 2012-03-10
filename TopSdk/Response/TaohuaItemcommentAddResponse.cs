using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaItemcommentAddResponse.
    /// </summary>
    public class TaohuaItemcommentAddResponse : TopResponse
    {
        /// <summary>
        /// 发表评论成功标志
        /// </summary>
        [XmlElement("add_comment_result")]
        public string AddCommentResult { get; set; }
    }
}
