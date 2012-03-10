using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PictureIsreferencedGetResponse.
    /// </summary>
    public class PictureIsreferencedGetResponse : TopResponse
    {
        /// <summary>
        /// 图片是否被引用
        /// </summary>
        [XmlElement("is_referenced")]
        public bool IsReferenced { get; set; }
    }
}
