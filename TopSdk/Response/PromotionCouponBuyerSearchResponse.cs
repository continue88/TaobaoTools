using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionCouponBuyerSearchResponse.
    /// </summary>
    public class PromotionCouponBuyerSearchResponse : TopResponse
    {
        /// <summary>
        /// 返回的优惠券信息
        /// </summary>
        [XmlArray("buyer_coupon_details")]
        [XmlArrayItem("buyer_coupon_detail")]
        public List<BuyerCouponDetail> BuyerCouponDetails { get; set; }

        /// <summary>
        /// 查询结果是总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
