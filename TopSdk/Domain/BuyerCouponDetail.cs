using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// BuyerCouponDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BuyerCouponDetail : TopObject
    {
        /// <summary>
        /// 优惠券使用条件，订单满多少分才能用这个优惠券，501就是满501分能使用。注意：返回的是“分”，不是“元”
        /// </summary>
        [XmlElement("condition")]
        public long Condition { get; set; }

        /// <summary>
        /// 优惠券编号
        /// </summary>
        [XmlElement("coupon_number")]
        public long CouponNumber { get; set; }

        /// <summary>
        /// 优惠券的面值，返回的是“分”，不是“元”，500代表500分相当于5元
        /// </summary>
        [XmlElement("denomination")]
        public long Denomination { get; set; }

        /// <summary>
        /// 优惠券有效期
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 已转送状态下，收到优惠券的淘宝昵称
        /// </summary>
        [XmlElement("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 优惠券来源，卖家或赠送人的淘宝昵称
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// unused：未使用，using：使用中,used,已经使用，overdue：已经过期，transfered：已经转发
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
