using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Trade Data Structure.
    /// </summary>
    [Serializable]
    public class Trade : TopObject
    {
        /// <summary>
        /// 卖家手工调整金额，精确到2位小数，单位：元。如：200.07，表示：200元7分。来源于订单价格修改，如果有多笔子订单的时候，这个为0，单笔的话则跟[order].adjust_fee一样
        /// </summary>
        [XmlElement("adjust_fee")]
        public string AdjustFee { get; set; }

        /// <summary>
        /// 买家的支付宝id号，在UIC中有记录，买家支付宝的唯一标示，不因为买家更换Email账号而改变。
        /// </summary>
        [XmlElement("alipay_id")]
        public long AlipayId { get; set; }

        /// <summary>
        /// 支付宝交易号，如：2009112081173831
        /// </summary>
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 创建交易接口成功后，返回的支付url
        /// </summary>
        [XmlElement("alipay_url")]
        public string AlipayUrl { get; set; }

        /// <summary>
        /// 淘宝下单成功了,但由于某种错误支付宝订单没有创建时返回的信息。taobao.trade.add接口专用
        /// </summary>
        [XmlElement("alipay_warn_msg")]
        public string AlipayWarnMsg { get; set; }

        /// <summary>
        /// 交易中剩余的确认收货金额（这个金额会随着子订单确认收货而不断减少，交易成功后会变为零）。精确到2位小数;单位:元。如:200.07，表示:200 元7分
        /// </summary>
        [XmlElement("available_confirm_fee")]
        public string AvailableConfirmFee { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [XmlElement("buyer_alipay_no")]
        public string BuyerAlipayNo { get; set; }

        /// <summary>
        /// 买家下单的地区
        /// </summary>
        [XmlElement("buyer_area")]
        public string BuyerArea { get; set; }

        /// <summary>
        /// 买家货到付款服务费。精确到2位小数;单位:元。如:12.07，表示:12元7分
        /// </summary>
        [XmlElement("buyer_cod_fee")]
        public string BuyerCodFee { get; set; }

        /// <summary>
        /// 买家邮件地址
        /// </summary>
        [XmlElement("buyer_email")]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// 买家备注旗帜（与淘宝网上订单的买家备注旗帜对应，只有买家才能查看该字段）
        /// </summary>
        [XmlElement("buyer_flag")]
        public long BuyerFlag { get; set; }

        /// <summary>
        /// 买家备注（与淘宝网上订单的买家备注对应，只有买家才能查看该字段）
        /// </summary>
        [XmlElement("buyer_memo")]
        public string BuyerMemo { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        [XmlElement("buyer_message")]
        public string BuyerMessage { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家获得积分,返点的积分。格式:100;单位:个。返点的积分要交易成功之后才能获得。
        /// </summary>
        [XmlElement("buyer_obtain_point_fee")]
        public long BuyerObtainPointFee { get; set; }

        /// <summary>
        /// 买家是否已评价。可选值:true(已评价),false(未评价)
        /// </summary>
        [XmlElement("buyer_rate")]
        public bool BuyerRate { get; set; }

        /// <summary>
        /// 买家可以通过此字段查询是否当前交易可以评论，can_rate=true可以评价，false则不能评价。
        /// </summary>
        [XmlElement("can_rate")]
        public bool CanRate { get; set; }

        /// <summary>
        /// 货到付款服务费。精确到2位小数;单位:元。如:12.07，表示:12元7分。
        /// </summary>
        [XmlElement("cod_fee")]
        public string CodFee { get; set; }

        /// <summary>
        /// 货到付款物流状态。 初始状态 NEW_CREATED, 接单成功 ACCEPTED_BY_COMPANY, 接单失败 REJECTED_BY_COMPANY, 接单超时 RECIEVE_TIMEOUT, 揽收成功 TAKEN_IN_SUCCESS, 揽收失败 TAKEN_IN_FAILED, 揽收超时 RECIEVE_TIMEOUT, 签收成功 SIGN_IN, 签收失败 REJECTED_BY_OTHER_SIDE, 订单等待发送给物流公司 WAITING_TO_BE_SENT, 用户取消物流订单 CANCELED
        /// </summary>
        [XmlElement("cod_status")]
        public string CodStatus { get; set; }

        /// <summary>
        /// 交易佣金。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("commission_fee")]
        public string CommissionFee { get; set; }

        /// <summary>
        /// 卖家发货时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("consign_time")]
        public string ConsignTime { get; set; }

        /// <summary>
        /// 交易创建时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 系统优惠金额（如打折，VIP，满就送等），精确到2位小数，单位：元。如：200.07，表示：200元7分
        /// </summary>
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 交易结束时间。交易成功时间(更新交易状态为成功的同时更新)/确认收货时间或者交易关闭时间 。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 快递代收款。精确到2位小数;单位:元。如:212.07，表示:212元7分
        /// </summary>
        [XmlElement("express_agency_fee")]
        public string ExpressAgencyFee { get; set; }

        /// <summary>
        /// 是否包含邮费。与available_confirm_fee同时使用。可选值:true(包含),false(不包含)
        /// </summary>
        [XmlElement("has_post_fee")]
        public bool HasPostFee { get; set; }

        /// <summary>
        /// 商品字符串编号(注意：iid近期即将废弃，请用num_iid参数)
        /// </summary>
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("invoice_name")]
        public string InvoiceName { get; set; }

        /// <summary>
        /// 是否是3D淘宝交易
        /// </summary>
        [XmlElement("is_3D")]
        public bool Is3D { get; set; }

        /// <summary>
        /// 是否需要物流宝发货的标识，如果为true，则需要可以用物流宝来发货，如果未false，则该订单不能用物流宝发货。
        /// </summary>
        [XmlElement("is_lgtype")]
        public bool IsLgtype { get; set; }

        /// <summary>
        /// 交易修改时间(用户对订单的任何修改都会更新此字段)。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 商品购买数量。取值范围：大于零的整数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 商品数字编号
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("order")]
        public List<Order> Orders { get; set; }

        /// <summary>
        /// 付款时间。格式:yyyy-MM-dd HH:mm:ss。订单的付款时间即为物流订单的创建时间。
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 实付金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 商品图片绝对途径
        /// </summary>
        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        /// <summary>
        /// 买家使用积分。格式:100;单位:个.
        /// </summary>
        [XmlElement("point_fee")]
        public long PointFee { get; set; }

        /// <summary>
        /// 邮费。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("post_fee")]
        public string PostFee { get; set; }

        /// <summary>
        /// 商品价格。精确到2位小数；单位：元。如：200.07，表示：200元7分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 交易促销详细信息
        /// </summary>
        [XmlElement("promotion")]
        public string Promotion { get; set; }

        /// <summary>
        /// 优惠详情
        /// </summary>
        [XmlArray("promotion_details")]
        [XmlArrayItem("promotion_detail")]
        public List<PromotionDetail> PromotionDetails { get; set; }

        /// <summary>
        /// 买家实际使用积分（扣除部分退款使用的积分）。格式:100;单位:个
        /// </summary>
        [XmlElement("real_point_fee")]
        public long RealPointFee { get; set; }

        /// <summary>
        /// 卖家实际收到的支付宝打款金额（由于子订单可以部分确认收货，这个金额会随着子订单的确认收货而不断增加，交易成功后等于买家实付款减去退款金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("received_payment")]
        public string ReceivedPayment { get; set; }

        /// <summary>
        /// 收货人的详细地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收货人的所在城市
        /// </summary>
        [XmlElement("receiver_city")]
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 收货人的所在地区
        /// </summary>
        [XmlElement("receiver_district")]
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// 收货人的手机号码
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收货人的姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人的电话号码
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收货人的所在省份
        /// </summary>
        [XmlElement("receiver_state")]
        public string ReceiverState { get; set; }

        /// <summary>
        /// 收货人的邮编
        /// </summary>
        [XmlElement("receiver_zip")]
        public string ReceiverZip { get; set; }

        /// <summary>
        /// 卖家支付宝账号
        /// </summary>
        [XmlElement("seller_alipay_no")]
        public string SellerAlipayNo { get; set; }

        /// <summary>
        /// 卖家货到付款服务费。精确到2位小数;单位:元。如:12.07，表示:12元7分。卖家不承担服务费的订单：未发货的订单获取服务费为0，发货后就能获取到正确值。
        /// </summary>
        [XmlElement("seller_cod_fee")]
        public string SellerCodFee { get; set; }

        /// <summary>
        /// 卖家邮件地址
        /// </summary>
        [XmlElement("seller_email")]
        public string SellerEmail { get; set; }

        /// <summary>
        /// 卖家备注旗帜（与淘宝网上订单的卖家备注旗帜对应，只有卖家才能查看该字段）
        /// </summary>
        [XmlElement("seller_flag")]
        public long SellerFlag { get; set; }

        /// <summary>
        /// 卖家备注（与淘宝网上订单的卖家备注对应，只有卖家才能查看该字段）
        /// </summary>
        [XmlElement("seller_memo")]
        public string SellerMemo { get; set; }

        /// <summary>
        /// 卖家手机
        /// </summary>
        [XmlElement("seller_mobile")]
        public string SellerMobile { get; set; }

        /// <summary>
        /// 卖家姓名
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 卖家电话
        /// </summary>
        [XmlElement("seller_phone")]
        public string SellerPhone { get; set; }

        /// <summary>
        /// 卖家是否已评价。可选值:true(已评价),false(未评价)
        /// </summary>
        [XmlElement("seller_rate")]
        public bool SellerRate { get; set; }

        /// <summary>
        /// 服务子订单列表
        /// </summary>
        [XmlArray("service_orders")]
        [XmlArrayItem("service_order")]
        public List<ServiceOrder> ServiceOrders { get; set; }

        /// <summary>
        /// 创建交易时的物流方式（交易完成前，物流方式有可能改变，但系统里的这个字段一直不变）。可选值：free(卖家包邮),post(平邮),express(快递),ems(EMS), virtual(虚拟发货)。
        /// </summary>
        [XmlElement("shipping_type")]
        public string ShippingType { get; set; }

        /// <summary>
        /// 交易快照详细信息
        /// </summary>
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 交易快照地址
        /// </summary>
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 交易状态。可选值:      * TRADE_NO_CREATE_PAY(没有创建支付宝交易)      * WAIT_BUYER_PAY(等待买家付款)      * WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款)      * WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货)      * TRADE_BUYER_SIGNED(买家已签收,货到付款专用)      * TRADE_FINISHED(交易成功)      * TRADE_CLOSED(付款以后用户退款成功，交易自动关闭)      * TRADE_CLOSED_BY_TAOBAO(付款以前，卖家或买家主动关闭交易)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易编号 (父订单的交易编号)
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// 超时到期时间。格式:yyyy-MM-dd HH:mm:ss。业务规则：  前提条件：只有在买家已付款，卖家已发货的情况下才有效  如果申请了退款，那么超时会落在子订单上；比如说3笔ABC，A申请了，那么返回的是BC的列表, 主定单不存在  如果没有申请过退款，那么超时会挂在主定单上；比如ABC，返回主定单，ABC的超时和主定单相同
        /// </summary>
        [XmlElement("timeout_action_time")]
        public string TimeoutActionTime { get; set; }

        /// <summary>
        /// 交易标题，以店铺名作为此标题的值。注:taobao.trades.get接口返回的Trade中的title是商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品金额（商品价格乘以数量的总金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 交易来源。  WAP(手机);HITAO(嗨淘);TOP(TOP平台);TAOBAO(普通淘宝);JHS(聚划算)  一笔订单可能同时有以上多个标记，则以逗号分隔
        /// </summary>
        [XmlElement("trade_from")]
        public string TradeFrom { get; set; }

        /// <summary>
        /// 交易备注，通过taobao.trade.add接口创建
        /// </summary>
        [XmlElement("trade_memo")]
        public string TradeMemo { get; set; }

        /// <summary>
        /// 交易类型列表，同时查询多种交易类型可用逗号分隔。默认同时查询guarantee_trade, auto_delivery, ec, cod的4种交易类型的数据   可选值   fixed(一口价)   auction(拍卖)   guarantee_trade(一口价、拍卖)   auto_delivery(自动发货)   independent_simple_trade(旺店入门版交易)   independent_shop_trade(旺店标准版交易)   ec(直冲)   cod(货到付款)   fenxiao(分销)   game_equipment(游戏装备)   shopex_trade(ShopEX交易)   netcn_trade(万网交易)   external_trade(统一外部交易)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
