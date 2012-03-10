using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaItemcommentsGetResponse.
    /// </summary>
    public class TaohuaItemcommentsGetResponse : TopResponse
    {
        /// <summary>
        /// 淘花商品评论
        /// </summary>
        [XmlElement("taohua_comments_result")]
        public TaohuaItemCommentResult TaohuaCommentsResult { get; set; }
    }
}
