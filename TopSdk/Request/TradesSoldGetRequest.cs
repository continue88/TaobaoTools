using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trades.sold.get
    /// </summary>
    public class TradesSoldGetRequest : ITopRequest<TradesSoldGetResponse>
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 查询交易创建时间结束。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 可选值有ershou(表示二手市场的订单）,service（商城服务子订单）
        /// </summary>
        public string ExtType { get; set; }

        /// <summary>
        /// 需要返回的字段。目前支持有：<br>  1. Trade中可以指定返回的fields:<br>  seller_nick, buyer_nick, title, type, created,  tid, seller_rate, buyer_rate, status, payment, discount_fee, adjust_fee, post_fee, total_fee, pay_time, end_time, modified, consign_time, buyer_obtain_point_fee, point_fee, real_point_fee, received_payment, commission_fee, pic_path, num_iid, num, price, cod_fee, cod_status, shipping_type, receiver_name, receiver_state, receiver_city, receiver_district, receiver_address, receiver_zip, receiver_mobile, receiver_phone，seller_flag <br>  2. Order中可以指定返回fields：orders.title, orders.pic_path, orders.price, orders.num, orders.num_iid, orders.sku_id, orders.refund_status, orders.status, orders.oid, orders.total_fee, orders.payment, orders.discount_fee, orders.adjust_fee, orders.sku_properties_name, orders.item_meal_name, orders.buyer_rate, orders.seller_rate, orders.outer_iid, orders.outer_sku_id, orders.refund_id, orders.seller_type <br>  3. fields：orders（返回2中Order的所有内容）
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 如果为true则查询模糊订单列表，根据返回订单中的buyer_nick来关联taobao.topats.visitlog.get接口返回的Acookie数据。
        /// </summary>
        public Nullable<bool> IsAcookie { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数; 默认值:1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。取值范围:大于零的整数; 默认值:40;最大值:100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 评价状态，默认查询所有评价状态的数据，除了默认值外每次只能查询一种状态。<br>  可选值：  RATE_UNBUYER(买家未评)  RATE_UNSELLER(卖家未评)  RATE_BUYER_UNSELLER(买家已评，卖家未评)  RATE_UNBUYER_SELLER(买家未评，卖家已评)
        /// </summary>
        public string RateStatus { get; set; }

        /// <summary>
        /// 查询三个月内交易创建时间开始。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        /// <summary>
        /// 交易状态，默认查询所有交易状态的数据，除了默认值外每次只能查询一种状态。  可选值：  TRADE_NO_CREATE_PAY(没有创建支付宝交易)  WAIT_BUYER_PAY(等待买家付款)  WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款)  WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货)  TRADE_BUYER_SIGNED(买家已签收,货到付款专用)  TRADE_FINISHED(交易成功)  TRADE_CLOSED(交易关闭)  TRADE_CLOSED_BY_TAOBAO(交易被淘宝关闭)  ALL_WAIT_PAY(包含：WAIT_BUYER_PAY、TRADE_NO_CREATE_PAY)  ALL_CLOSED(包含：TRADE_CLOSED、TRADE_CLOSED_BY_TAOBAO)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 卖家对交易的自定义分组标签，目前可选值为：time_card（点卡软件代充），fee_card（话费软件代充）
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 交易类型列表，同时查询多种交易类型可用逗号分隔。默认同时查询guarantee_trade, auto_delivery, ec, cod的4种交易类型的数据 。 可选值： fixed(一口价) auction(拍卖) guarantee_trade(一口价、拍卖) independent_simple_trade(旺店入门版交易) independent_shop_trade(旺店标准版交易) auto_delivery(自动发货) ec(直冲) cod(货到付款) game_equipment(游戏装备) shopex_trade(ShopEX交易) netcn_trade(万网交易) external_trade(统一外部交易) instant_trade (即时到账) b2c_cod(大商家货到付款) hotel_trade(酒店类型交易) super_market_trade(商超交易) super_market_cod_trade(商超货到付款交易) taohua(淘花网交易类型） waimai(外卖交易类型） nopaid（即时到帐/趣味猜交易类型） 注：guarantee_trade是一个组合查询条件，并不是一种交易类型，获取批量或单个订单中不会返回此种类型的订单。
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 是否启用has_next的分页方式，如果指定true,则返回的结果中不包含总记录数，但是会新增一个是否存在下一页的的字段，通过此种方式获取增量交易，接口调用成功率在原有的基础上有所提升。
        /// </summary>
        public Nullable<bool> UseHasNext { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trades.sold.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("ext_type", this.ExtType);
            parameters.Add("fields", this.Fields);
            parameters.Add("is_acookie", this.IsAcookie);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("rate_status", this.RateStatus);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("status", this.Status);
            parameters.Add("tag", this.Tag);
            parameters.Add("type", this.Type);
            parameters.Add("use_has_next", this.UseHasNext);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
        }

        #endregion
    }
}
