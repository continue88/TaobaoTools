using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaOrder Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaOrder : TopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 1、wait_pay:等待买家付款、  2、timeout_close: 系统超时关闭、 　  3、pay_suc:交易成功、　　　　　　  4、uncreate_trade:没有创建外部交易（支付宝交易）、　 　　              　　　　　  5、micropay_trade_close: 交易被淘宝微支付关闭、　 　　           　　　　　　　6、alipay_trade_close:交易被支付宝关闭、　 　　
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 商品图片链接
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
