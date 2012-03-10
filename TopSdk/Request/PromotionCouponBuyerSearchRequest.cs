using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.coupon.buyer.search
    /// </summary>
    public class PromotionCouponBuyerSearchRequest : ITopRequest<PromotionCouponBuyerSearchResponse>
    {
        /// <summary>
        /// 查询有效期晚于查询日期的所有优惠券
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 店铺的名称，就是卖家的昵称
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// unused：未使用，using：使用中,used,已经使用，overdue：已经过期，transfered：已经转发
        /// </summary>
        public string Status { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.coupon.buyer.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("status", this.Status);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 20);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 10);
            RequestValidator.ValidateRequired("status", this.Status);
        }

        #endregion
    }
}
