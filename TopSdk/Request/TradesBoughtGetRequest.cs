using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trades.bought.get
    /// </summary>
    public class TradesBoughtGetRequest : ITopRequest<TradesBoughtGetResponse>
    {
        /// <summary>
        /// 查询交易创建时间结束。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 可选值有ershou(二手市场的订单）,service（商城服务子订单）作为扩展类型筛选只能做单个ext_type查询，不能全部查询所有的ext_type类型
        /// </summary>
        public string ExtType { get; set; }

        /// <summary>
        /// 需要返回的字段。目前支持有：     1. Trade中可以指定返回的fields： seller_nick, buyer_nick, title, type, created, sid, tid, seller_rate, buyer_rate, can_rate, status, payment, discount_fee, adjust_fee, post_fee, total_fee, pay_time, end_time, modified, consign_time, buyer_obtain_point_fee, point_fee, real_point_fee, received_payment,  pic_path, num_iid, num, price, cod_fee, cod_status, shipping_type, receiver_name, receiver_state, receiver_city, receiver_district, receiver_address, receiver_zip, receiver_mobile, receiver_phone     2. Order中可以指定返回fields： orders.title, orders.pic_path, orders.price, orders.num, orders.num_iid, orders.sku_id, orders.refund_status, orders.status, orders.oid, orders.total_fee, orders.payment, orders.discount_fee, orders.adjust_fee, orders.sku_properties_name, orders.item_meal_name, orders.buyer_rate, orders.seller_rate, orders.outer_iid, orders.outer_sku_id, orders.refund_id, orders.seller_type                               3. fields：orders（返回Order的所有内容）
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数; 默认值:1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。取值范围:大于零的整数; 默认值:40;最大值:100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 交易是否评价.默认查询所有评价状态的数据，除了默认值外每次只能查询一种状态。  可选值： RATE_UNBUYER(买家未评) RATE_UNSELLER(卖家未评) RATE_BUYER_UNSELLER(买家已评，卖家未评) RATE_UNBUYER_SELLER(买家未评，卖家已评)
        /// </summary>
        public string RateStatus { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 是否显示订单回收站删除的订单，false不显示true（显示），如果不传入，默认是不显示的
        /// </summary>
        public Nullable<bool> ShowDeleted { get; set; }

        /// <summary>
        /// 查询交易创建时间开始。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        /// <summary>
        /// 交易状态，默认查询所有交易状态的数据，除了默认值外每次只能查询一种状态。   交易状态可选值        TRADE_NO_CREATE_PAY(没有创建支付宝交易)      WAIT_BUYER_PAY(等待买家付款)      WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款)      WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货)      TRADE_BUYER_SIGNED(买家已签收,货到付款专用)      TRADE_FINISHED(交易成功)      TRADE_CLOSED(交易关闭)      TRADE_CLOSED_BY_TAOBAO(交易被淘宝关闭)      ALL_WAIT_PAY(包含：WAIT_BUYER_PAY、TRADE_NO_CREATE_PAY)      ALL_CLOSED(包含：TRADE_CLOSED、TRADE_CLOSED_BY_TAOBAO)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 交易类型列表，同时查询多种交易类型可用逗号分隔。默认同时查询guarantee_trade, auto_delivery, ec, cod的4种交易类型的数据  交易类型可选值  fixed(一口价)  auction(拍卖)  guarantee_trade(一口价、拍卖)  tmall_service_trade（虚拟服务订单）  independent_simple_trade(旺店入门版交易)  independent_shop_trade(旺店标准版交易)  auto_delivery(自动发货)  ec(直冲)  cod(货到付款)  fenxiao(分销)  game_equipment(游戏装备)  shopex_trade(ShopEX交易)  netcn_trade(万网交易)  external_trade(统一外部交易  instant_trade (即时到账)  b2c_cod(大商家货到付款)  hotel_trade(酒店类型交易)  super_market_trade(商超交易)  super_market_cod_trade(商超货到付款交易)  taohua(桃花网交易类型）waimai(外卖交易类型） nopaid（即时到帐/趣味猜交易类型）
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trades.bought.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("ext_type", this.ExtType);
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("rate_status", this.RateStatus);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("show_deleted", this.ShowDeleted);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
        }

        #endregion
    }
}
