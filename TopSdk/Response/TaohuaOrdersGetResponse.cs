using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaOrdersGetResponse.
    /// </summary>
    public class TaohuaOrdersGetResponse : TopResponse
    {
        /// <summary>
        /// 淘花订单列表数据结构对象
        /// </summary>
        [XmlElement("taohua_order_result")]
        public TaohuaOrders TaohuaOrderResult { get; set; }
    }
}
