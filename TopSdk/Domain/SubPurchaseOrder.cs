using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubPurchaseOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SubPurchaseOrder : TopObject
    {
        /// <summary>
        /// 买家实付金额。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("buyer_payment")]
        public string BuyerPayment { get; set; }

        /// <summary>
        /// 创建时间。格式 yyyy-MM-dd HH:mm:ss 。
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 分销商实付金额。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("distributor_payment")]
        public string DistributorPayment { get; set; }

        /// <summary>
        /// 分销平台的子采购单主键
        /// </summary>
        [XmlElement("fenxiao_id")]
        public long FenxiaoId { get; set; }

        /// <summary>
        /// 子采购单id，淘宝交易主键，采购单未付款时为0.（即将废掉）
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 分销平台上商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 分销平台上商品商家编码。
        /// </summary>
        [XmlElement("item_outer_id")]
        public string ItemOuterId { get; set; }

        /// <summary>
        /// 商品购买数量。取值范围:大于零的整数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 老的SKU属性值。如: 颜色:红色:别名;尺码:L:别名
        /// </summary>
        [XmlElement("old_sku_properties")]
        public string OldSkuProperties { get; set; }

        /// <summary>
        /// 单个商品价格。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 商品的SKU id。该字段即将被废弃，所以值可能不准确，建议使用sku_outer_id，sku_properties这两个值
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// SKU商家编码。
        /// </summary>
        [XmlElement("sku_outer_id")]
        public string SkuOuterId { get; set; }

        /// <summary>
        /// SKU属性值。如: 颜色:红色:别名;尺码:L:别名
        /// </summary>
        [XmlElement("sku_properties")]
        public string SkuProperties { get; set; }

        /// <summary>
        /// 快照地址。
        /// </summary>
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 交易状态。可选值：<br> WAIT_BUYER_PAY(等待付款)<br> WAIT_CONFIRM(付款信息待确认)<br> WAIT_CONFIRM_WAIT_SEND_GOODS(付款信息待确认，待发货)<br> WAIT_CONFIRM_SEND_GOODS(付款信息待确认，已发货)<br> WAIT_CONFIRM_GOODS_CONFIRM(付款信息待确认，已收货)<br> WAIT_SELLER_SEND_GOODS(已付款，待发货)<br> WAIT_BUYER_CONFIRM_GOODS(已付款，已发货)<br> CONFIRM_WAIT_SEND_GOODS(付款信息已确认，待发货)<br> CONFIRM_SEND_GOODS(付款信息已确认，已发货)<br> TRADE_REFUNDED(已退款)<br> TRADE_REFUNDING(退款中)<br> TRADE_FINISHED(交易成功)<br> TRADE_CLOSED(交易关闭)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子订单ID(经销不显示)
        /// </summary>
        [XmlElement("sub_tc_order_id")]
        public long SubTcOrderId { get; set; }

        /// <summary>
        /// TC订单ID（经销不显示）
        /// </summary>
        [XmlElement("tc_order_id")]
        public long TcOrderId { get; set; }

        /// <summary>
        /// 商品标题。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 分销商应付金额。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }
    }
}
