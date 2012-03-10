using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaohuaBoughtitemIsResponse.
    /// </summary>
    public class TaohuaBoughtitemIsResponse : TopResponse
    {
        /// <summary>
        /// 返回结果，true代表该商品已经被购买过，false代表该商品还没有被购买过
        /// </summary>
        [XmlElement("is_bought")]
        public bool IsBought { get; set; }
    }
}
