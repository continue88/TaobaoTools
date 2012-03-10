using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.distributors.get
    /// </summary>
    public class FenxiaoDistributorsGetRequest : ITopRequest<FenxiaoDistributorsGetResponse>
    {
        /// <summary>
        /// 分销商用户名列表。多个之间以“,”分隔;最多支持50个分销商用户名。
        /// </summary>
        public string Nicks { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.distributors.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nicks", this.Nicks);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("nicks", this.Nicks);
        }

        #endregion
    }
}
