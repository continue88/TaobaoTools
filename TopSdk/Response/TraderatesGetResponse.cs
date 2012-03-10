using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TraderatesGetResponse.
    /// </summary>
    public class TraderatesGetResponse : TopResponse
    {
        /// <summary>
        /// 当使用use_has_next时返回信息，如果还有下一页则返回true
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 搜索到的评价总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

        /// <summary>
        /// 评价列表。返回的TradeRate包含的具体信息为入参fields请求的字段信息
        /// </summary>
        [XmlArray("trade_rates")]
        [XmlArrayItem("trade_rate")]
        public List<TradeRate> TradeRates { get; set; }
    }
}
