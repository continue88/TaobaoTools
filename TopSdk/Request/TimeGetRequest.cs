using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.time.get
    /// </summary>
    public class TimeGetRequest : ITopRequest<TimeGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.time.get";
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
