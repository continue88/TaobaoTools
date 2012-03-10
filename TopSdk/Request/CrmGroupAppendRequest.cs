using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.group.append
    /// </summary>
    public class CrmGroupAppendRequest : ITopRequest<CrmGroupAppendResponse>
    {
        /// <summary>
        /// 添加的来源分组
        /// </summary>
        public Nullable<long> FromGroupId { get; set; }

        /// <summary>
        /// 添加的目标分组
        /// </summary>
        public Nullable<long> ToGroupId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.group.append";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("from_group_id", this.FromGroupId);
            parameters.Add("to_group_id", this.ToGroupId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("from_group_id", this.FromGroupId);
            RequestValidator.ValidateMinValue("from_group_id", this.FromGroupId, 1);
            RequestValidator.ValidateRequired("to_group_id", this.ToGroupId);
            RequestValidator.ValidateMinValue("to_group_id", this.ToGroupId, 1);
        }

        #endregion
    }
}
