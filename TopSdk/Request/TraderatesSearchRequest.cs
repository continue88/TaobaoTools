using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderates.search
    /// </summary>
    public class TraderatesSearchRequest : ITopRequest<TraderatesSearchResponse>
    {
        /// <summary>
        /// 商品的数字id
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页显示的条数，允许值：5、10、20、40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 商品所属的卖家nick
        /// </summary>
        public string SellerNick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderates.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("seller_nick", this.SellerNick);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 40);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("seller_nick", this.SellerNick);
            RequestValidator.ValidateMaxLength("seller_nick", this.SellerNick, 32);
        }

        #endregion
    }
}
