using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.aftersale.get
    /// </summary>
    public class AftersaleGetRequest : ITopRequest<AftersaleGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.aftersale.get";
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
