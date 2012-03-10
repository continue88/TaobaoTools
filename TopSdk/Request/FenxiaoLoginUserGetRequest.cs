using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.login.user.get
    /// </summary>
    public class FenxiaoLoginUserGetRequest : ITopRequest<FenxiaoLoginUserGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.login.user.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            return parameters;
        }

        public void Validate()
        {
        }

        #endregion
    }
}
