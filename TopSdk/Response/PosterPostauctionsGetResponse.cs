using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PosterPostauctionsGetResponse.
    /// </summary>
    public class PosterPostauctionsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回画报商品列表
        /// </summary>
        [XmlArray("posterauctions")]
        [XmlArrayItem("huabao_auction_info")]
        public List<HuabaoAuctionInfo> Posterauctions { get; set; }
    }
}
