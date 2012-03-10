using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.poster.channels.get
    /// </summary>
    public class PosterChannelsGetRequest : ITopRequest<PosterChannelsGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.poster.channels.get";
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
