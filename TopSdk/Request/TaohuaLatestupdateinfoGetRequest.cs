using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.latestupdateinfo.get
    /// </summary>
    public class TaohuaLatestupdateinfoGetRequest : ITopRequest<TaohuaLatestupdateinfoGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.latestupdateinfo.get";
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
