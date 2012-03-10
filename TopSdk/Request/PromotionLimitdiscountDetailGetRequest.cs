using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.limitdiscount.detail.get
    /// </summary>
    public class PromotionLimitdiscountDetailGetRequest : ITopRequest<PromotionLimitdiscountDetailGetResponse>
    {
        /// <summary>
        /// 限时打折ID。这个针对查询唯一限时打折情况。
        /// </summary>
        public Nullable<long> LimitDiscountId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.limitdiscount.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("limit_discount_id", this.LimitDiscountId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("limit_discount_id", this.LimitDiscountId);
        }

        #endregion
    }
}
