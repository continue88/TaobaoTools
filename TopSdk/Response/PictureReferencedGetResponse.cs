using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PictureReferencedGetResponse.
    /// </summary>
    public class PictureReferencedGetResponse : TopResponse
    {
        /// <summary>
        /// 引用详情列表
        /// </summary>
        [XmlArray("references")]
        [XmlArrayItem("reference_detail")]
        public List<ReferenceDetail> References { get; set; }
    }
}
