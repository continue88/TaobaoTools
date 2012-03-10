using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.childcates.get
    /// </summary>
    public class TaohuaChildcatesGetRequest : ITopRequest<TaohuaChildcatesGetResponse>
    {
        /// <summary>
        /// 通过类目ID获取它的子类目列表
        /// </summary>
        public Nullable<long> CateId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.childcates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cate_id", this.CateId);
            return parameters;
        }

        public void Validate()
        {
        }

        #endregion
    }
}
