using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update.listing
    /// </summary>
    public class ItemUpdateListingRequest : ITopRequest<ItemUpdateListingResponse>
    {
        /// <summary>
        /// 需要上架的商品的数量。取值范围:大于零的整数。如果商品有sku，则上架数量默认为所有sku数量总和，不可修改。否则商品数量根据设置数量调整为num
        /// </summary>
        public Nullable<long> Num { get; set; }

        /// <summary>
        /// 商品数字ID，该参数必须
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update.listing";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("num", this.Num);
            parameters.Add("num_iid", this.NumIid);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num", this.Num);
            RequestValidator.ValidateMinValue("num", this.Num, 0);
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
            RequestValidator.ValidateMinValue("num_iid", this.NumIid, 0);
        }

        #endregion
    }
}
