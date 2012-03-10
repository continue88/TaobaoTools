using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmShopvipCancelResponse.
    /// </summary>
    public class CrmShopvipCancelResponse : TopResponse
    {
        /// <summary>
        /// 返回操作是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
