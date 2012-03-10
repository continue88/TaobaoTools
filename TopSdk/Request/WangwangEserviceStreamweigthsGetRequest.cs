using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.eservice.streamweigths.get
    /// </summary>
    public class WangwangEserviceStreamweigthsGetRequest : ITopRequest<WangwangEserviceStreamweigthsGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.eservice.streamweigths.get";
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
