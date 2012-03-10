using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.trades.fullinfo.get
    /// </summary>
    public class TopatsTradesFullinfoGetRequest : ITopRequest<TopatsTradesFullinfoGetResponse>
    {
        /// <summary>
        /// 指定此字段表示获取的所有订单都按照这个字段请求来返回，同（taobao.trade.fullinfo.get的fields一样）。 1.Trade中可以指定返回的fields：seller_nick, buyer_nick, title, type, created, sid, tid, seller_rate, buyer_rate, status, payment, discount_fee, adjust_fee, post_fee, total_fee, pay_time, end_time, modified, consign_time, buyer_obtain_point_fee, point_fee, real_point_fee, received_payment, commission_fee, buyer_memo, seller_memo, alipay_no, buyer_message, pic_path, num_iid, num, price, buyer_alipay_no, receiver_name, receiver_state, receiver_city, receiver_district, receiver_address, receiver_zip, receiver_mobile, receiver_phone, buyer_email, seller_alipay_no, seller_mobile, seller_phone, seller_name, seller_email, available_confirm_fee, has_post_fee, timeout_action_time, snapshot_url, cod_fee, cod_status, shipping_type, trade_memo, is_3D 2.Order中可以指定返回fields：orders.title, orders.pic_path, orders.price, orders.num, orders.num_iid, orders.sku_id, orders.refund_status, orders.status, orders.oid, orders.total_fee, orders.payment, orders.discount_fee, orders.adjust_fee, orders.snapshot_url, orders.timeout_action_time，orders.sku_properties_name, orders.item_meal_name, item_memo,orders.buyer_rate, orders.seller_rate, orders.outer_iid, orders.outer_sku_id, orders.refund_id, orders.seller_type 3.fields：orders（返回Order的所有内容）
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 批量获取的订单id列表，每个订单id必需是合法的数字类型的tid，每个tid之间以";"分隔，至少要指定一个tid，最多不超过40个tid
        /// </summary>
        public string Tids { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.trades.fullinfo.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("tids", this.Tids);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("tids", this.Tids);
        }

        #endregion
    }
}
