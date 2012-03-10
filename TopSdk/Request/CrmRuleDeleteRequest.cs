using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.rule.delete
    /// </summary>
    public class CrmRuleDeleteRequest : ITopRequest<CrmRuleDeleteResponse>
    {
        /// <summary>
        /// 规则id
        /// </summary>
        public Nullable<long> RuleId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.rule.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("rule_id", this.RuleId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("rule_id", this.RuleId);
            RequestValidator.ValidateMinValue("rule_id", this.RuleId, 1);
        }

        #endregion
    }
}
