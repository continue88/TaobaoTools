using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.grouptask.check
    /// </summary>
    public class CrmGrouptaskCheckRequest : ITopRequest<CrmGrouptaskCheckResponse>
    {
        /// <summary>
        /// 分组id
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.grouptask.check";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("group_id", this.GroupId);
        }

        #endregion
    }
}
