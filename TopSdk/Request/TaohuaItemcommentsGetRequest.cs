using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.itemcomments.get
    /// </summary>
    public class TaohuaItemcommentsGetRequest : ITopRequest<TaohuaItemcommentsGetResponse>
    {
        /// <summary>
        /// 指定商品的ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 页码。  取值范围：大于零的整数  默认值：1 即返回第一页数据
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页记录数  取值范围：大于零的整数   默认值：10 即每页返回10条数据
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.itemcomments.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
        }

        #endregion
    }
}
