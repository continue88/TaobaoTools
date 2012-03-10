using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.group.add
    /// </summary>
    public class CrmGroupAddRequest : ITopRequest<CrmGroupAddResponse>
    {
        /// <summary>
        /// 分组名称，每个卖家最多可以拥有100个分组
        /// </summary>
        public string GroupName { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.group.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_name", this.GroupName);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("group_name", this.GroupName);
            RequestValidator.ValidateMaxLength("group_name", this.GroupName, 15);
        }

        #endregion
    }
}
