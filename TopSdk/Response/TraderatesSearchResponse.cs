using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TraderatesSearchResponse.
    /// </summary>
    public class TraderatesSearchResponse : TopResponse
    {
        /// <summary>
        /// 搜索到的评价总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

        /// <summary>
        /// 评价列表。
        /// </summary>
        [XmlArray("trade_rates")]
        [XmlArrayItem("trade_rate")]
        public List<TradeRate> TradeRates { get; set; }
    }
}
