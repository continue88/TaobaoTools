using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.huabao.poster.goodsinfo.get
    /// </summary>
    public class HuabaoPosterGoodsinfoGetRequest : ITopRequest<HuabaoPosterGoodsinfoGetResponse>
    {
        /// <summary>
        /// 画报的ID
        /// </summary>
        public Nullable<long> PosterId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.huabao.poster.goodsinfo.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("poster_id", this.PosterId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("poster_id", this.PosterId);
        }

        #endregion
    }
}
