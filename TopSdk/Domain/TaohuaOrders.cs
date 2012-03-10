using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaohuaOrders Data Structure.
    /// </summary>
    [Serializable]
    public class TaohuaOrders : TopObject
    {
        /// <summary>
        /// 淘花用户已买到订单列表数据结构
        /// </summary>
        [XmlArray("taohua_orders")]
        [XmlArrayItem("taohua_order")]
        public List<TaohuaOrder> TaohuaOrders_ { get; set; }

        /// <summary>
        /// 返回的订单列表的总数
        /// </summary>
        [XmlElement("total_order")]
        public long TotalOrder { get; set; }
    }
}
