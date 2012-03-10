using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.grade.get
    /// </summary>
    public class CrmGradeGetRequest : ITopRequest<CrmGradeGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.grade.get";
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
