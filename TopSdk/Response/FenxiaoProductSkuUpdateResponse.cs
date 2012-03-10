using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoProductSkuUpdateResponse.
    /// </summary>
    public class FenxiaoProductSkuUpdateResponse : TopResponse
    {
        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
