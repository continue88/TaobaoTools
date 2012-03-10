using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.productcats.get
    /// </summary>
    public class FenxiaoProductcatsGetRequest : ITopRequest<FenxiaoProductcatsGetResponse>
    {
        /// <summary>
        /// 返回字段列表
        /// </summary>
        public string Fields { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.productcats.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            return parameters;
        }

        public void Validate()
        {
        }

        #endregion
    }
}
