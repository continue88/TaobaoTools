using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaItemLikeResponse.
    /// </summary>
    public class TaohuaItemLikeResponse : TopResponse
    {
        /// <summary>
        /// 成功返回success
        /// </summary>
        [XmlElement("like_result")]
        public string LikeResult { get; set; }
    }
}
