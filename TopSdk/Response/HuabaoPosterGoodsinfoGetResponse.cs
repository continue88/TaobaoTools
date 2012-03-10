using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HuabaoPosterGoodsinfoGetResponse.
    /// </summary>
    public class HuabaoPosterGoodsinfoGetResponse : TopResponse
    {
        /// <summary>
        /// 和画报相关的商品信息
        /// </summary>
        [XmlArray("goodsinfolist")]
        [XmlArrayItem("poster_goods_info")]
        public List<PosterGoodsInfo> Goodsinfolist { get; set; }
    }
}
