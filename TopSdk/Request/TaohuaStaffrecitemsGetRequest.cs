using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.staffrecitems.get
    /// </summary>
    public class TaohuaStaffrecitemsGetRequest : ITopRequest<TaohuaStaffrecitemsGetResponse>
    {
        /// <summary>
        /// 推荐的商品类型:  1. free:获取推荐的免费商品  2. charges:获取推荐的收费商品
        /// </summary>
        public string ItemType { get; set; }

        /// <summary>
        /// 当前页数，大于0的整数，默认值1，代表第一页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页显示最大条数，要求：大于0的整数。默认为5，代表每页显示5条
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.staffrecitems.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_type", this.ItemType);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_type", this.ItemType);
        }

        #endregion
    }
}
