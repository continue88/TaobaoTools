using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.shopvip.cancel
    /// </summary>
    public class CrmShopvipCancelRequest : ITopRequest<CrmShopvipCancelResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.shopvip.cancel";
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
