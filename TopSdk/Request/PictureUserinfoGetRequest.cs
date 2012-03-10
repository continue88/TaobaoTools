using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.userinfo.get
    /// </summary>
    public class PictureUserinfoGetRequest : ITopRequest<PictureUserinfoGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.userinfo.get";
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
