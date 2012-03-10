using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.templates.get
    /// </summary>
    public class ItemTemplatesGetRequest : ITopRequest<ItemTemplatesGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.templates.get";
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
