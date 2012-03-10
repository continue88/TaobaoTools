using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.grades.get
    /// </summary>
    public class FenxiaoGradesGetRequest : ITopRequest<FenxiaoGradesGetResponse>
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.grades.get";
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
