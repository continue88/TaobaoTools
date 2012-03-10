using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaDirectoryGetResponse.
    /// </summary>
    public class TaohuaDirectoryGetResponse : TopResponse
    {
        /// <summary>
        /// 淘花文档目录
        /// </summary>
        [XmlElement("tree_vo")]
        public TaohuaRootDirectory TreeVo { get; set; }
    }
}
