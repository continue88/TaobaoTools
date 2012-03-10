using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RefundsReceiveGetResponse.
    /// </summary>
    public class RefundsReceiveGetResponse : TopResponse
    {
        /// <summary>
        /// 搜索到的退款信息列表
        /// </summary>
        [XmlArray("refunds")]
        [XmlArrayItem("refund")]
        public List<Refund> Refunds { get; set; }

        /// <summary>
        /// 搜索到的交易信息总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
