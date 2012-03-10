using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.rules.get
    /// </summary>
    public class CrmRulesGetRequest : ITopRequest<CrmRulesGetResponse>
    {
        /// <summary>
        /// 当前显示第几页，如果current_page超过页码范围或者小于页码范围，将直接返回空白页
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 一页返回的记录的个数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.rules.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("page_size", this.PageSize);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateMaxValue("current_page", this.CurrentPage, 1000000);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
