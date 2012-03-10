using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.sku.get
    /// </summary>
    public class ItemSkuGetRequest : ITopRequest<ItemSkuGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表。可选值：Sku结构体中的所有字段；字段之间用“,”分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 卖家nick(num_iid和nick必传一个)
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 商品的数字IID（num_iid和nick必传一个，推荐用num_iid）
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// Sku的id。可以通过taobao.item.get得到
        /// </summary>
        public Nullable<long> SkuId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.sku.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("sku_id", this.SkuId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMinValue("num_iid", this.NumIid, 0);
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
        }

        #endregion
    }
}
