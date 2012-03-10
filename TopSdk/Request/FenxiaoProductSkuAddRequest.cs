using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.sku.add
    /// </summary>
    public class FenxiaoProductSkuAddRequest : ITopRequest<FenxiaoProductSkuAddResponse>
    {
        /// <summary>
        /// 代销采购价
        /// </summary>
        public string AgentCostPrice { get; set; }

        /// <summary>
        /// 经销采购价
        /// </summary>
        public string DealerCostPrice { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// sku属性
        /// </summary>
        public string Properties { get; set; }

        /// <summary>
        /// sku产品库存，在0到1000000之间，如果不传，则库存为0
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        public string SkuNumber { get; set; }

        /// <summary>
        /// 市场价，最大值1000000000
        /// </summary>
        public string StandardPrice { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.sku.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_cost_price", this.AgentCostPrice);
            parameters.Add("dealer_cost_price", this.DealerCostPrice);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("properties", this.Properties);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("sku_number", this.SkuNumber);
            parameters.Add("standard_price", this.StandardPrice);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("product_id", this.ProductId);
            RequestValidator.ValidateRequired("properties", this.Properties);
            RequestValidator.ValidateMaxValue("quantity", this.Quantity, 1000000);
            RequestValidator.ValidateMinValue("quantity", this.Quantity, 0);
            RequestValidator.ValidateRequired("standard_price", this.StandardPrice);
        }

        #endregion
    }
}
