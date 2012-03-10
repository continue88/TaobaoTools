using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JianghuFanFollowResponse.
    /// </summary>
    public class JianghuFanFollowResponse : TopResponse
    {
        /// <summary>
        /// true 成功。false 失败
        /// </summary>
        [XmlElement("follow_result")]
        public bool FollowResult { get; set; }
    }
}
