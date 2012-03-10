using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmRuleAddResponse.
    /// </summary>
    public class CrmRuleAddResponse : TopResponse
    {
        /// <summary>
        /// 返回规则添加是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 新增的规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public long RuleId { get; set; }
    }
}
