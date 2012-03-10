using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PictureDeleteResponse.
    /// </summary>
    public class PictureDeleteResponse : TopResponse
    {
        /// <summary>
        /// 是否删除
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
