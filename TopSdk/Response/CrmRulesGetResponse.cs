using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmRulesGetResponse.
    /// </summary>
    public class CrmRulesGetResponse : TopResponse
    {
        /// <summary>
        /// 规则列表
        /// </summary>
        [XmlArray("rule_list")]
        [XmlArrayItem("rule_data")]
        public List<RuleData> RuleList { get; set; }

        /// <summary>
        /// 记录的总条数
        /// </summary>
        [XmlElement("total_result")]
        public long TotalResult { get; set; }
    }
}
