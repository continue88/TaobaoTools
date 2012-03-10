using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.image.delete
    /// </summary>
    public class FenxiaoProductImageDeleteRequest : ITopRequest<FenxiaoProductImageDeleteResponse>
    {
        /// <summary>
        /// 图片位置
        /// </summary>
        public Nullable<long> Position { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.image.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("position", this.Position);
            parameters.Add("product_id", this.ProductId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("position", this.Position);
            RequestValidator.ValidateRequired("product_id", this.ProductId);
        }

        #endregion
    }
}
