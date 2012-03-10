using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FavoriteAddResponse.
    /// </summary>
    public class FavoriteAddResponse : TopResponse
    {
        /// <summary>
        /// 是否收藏成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
