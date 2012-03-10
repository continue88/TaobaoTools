using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.marketing.promotions.get
    /// </summary>
    public class MarketingPromotionsGetRequest : ITopRequest<MarketingPromotionsGetResponse>
    {
        /// <summary>
        /// 需返回的优惠策略结构字段列表。可选值为Promotion中所有字段，如：promotion_id, promotion_title, item_id, status, tag_id等等
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 商品数字ID。根据该ID查询商品下通过第三方工具设置的所有优惠策略
        /// </summary>
        public string NumIid { get; set; }

        /// <summary>
        /// 优惠策略状态。可选值：ACTIVE(有效)，UNACTIVE(无效)，若不传或者传入其他值，则默认查询全部
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        public Nullable<long> TagId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.marketing.promotions.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("status", this.Status);
            parameters.Add("tag_id", this.TagId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
        }

        #endregion
    }
}
