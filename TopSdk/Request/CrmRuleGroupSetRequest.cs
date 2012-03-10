using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.rule.group.set
    /// </summary>
    public class CrmRuleGroupSetRequest : ITopRequest<CrmRuleGroupSetResponse>
    {
        /// <summary>
        /// 需要添加到规则的分组
        /// </summary>
        public string AddGroups { get; set; }

        /// <summary>
        /// 需要删除的分组
        /// </summary>
        public string DeleteGroups { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        public Nullable<long> RuleId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.rule.group.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("add_groups", this.AddGroups);
            parameters.Add("delete_groups", this.DeleteGroups);
            parameters.Add("rule_id", this.RuleId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("add_groups", this.AddGroups, 10);
            RequestValidator.ValidateMaxListSize("delete_groups", this.DeleteGroups, 10);
            RequestValidator.ValidateRequired("rule_id", this.RuleId);
            RequestValidator.ValidateMinValue("rule_id", this.RuleId, 1);
        }

        #endregion
    }
}
