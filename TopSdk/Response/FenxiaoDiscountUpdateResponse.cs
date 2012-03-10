using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDiscountUpdateResponse.
    /// </summary>
    public class FenxiaoDiscountUpdateResponse : TopResponse
    {
        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
