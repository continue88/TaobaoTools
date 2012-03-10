using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.skus.get
    /// </summary>
    public class FenxiaoProductSkusGetRequest : ITopRequest<FenxiaoProductSkusGetResponse>
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.skus.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id", this.ProductId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("product_id", this.ProductId);
        }

        #endregion
    }
}
