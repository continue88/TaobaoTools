using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.members.increment.get
    /// </summary>
    public class CrmMembersIncrementGetRequest : ITopRequest<CrmMembersIncrementGetResponse>
    {
        /// <summary>
        /// 显示第几页的会员，如果输入的页码大于总共的页码数，例如总共10页，但是current_page的值为11，则返回空白页，最小页数为1
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 对应买家 最后一次 确认收货或者关闭交易的时间，如果不填写此字段，默认为当前时间
        /// </summary>
        public Nullable<DateTime> EndModify { get; set; }

        /// <summary>
        /// 会员等级，1：普通客户，2：高级会员，3：VIP会员， 4：至尊VIP会员
        /// </summary>
        public Nullable<long> Grade { get; set; }

        /// <summary>
        /// 每页显示的会员数，page_size的值不能超过100，最小值要大于1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 对应买家 最后一次 确认收货或者关闭交易的时间
        /// </summary>
        public Nullable<DateTime> StartModify { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.members.increment.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("end_modify", this.EndModify);
            parameters.Add("grade", this.Grade);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modify", this.StartModify);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateMaxValue("current_page", this.CurrentPage, 1000000);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("grade", this.Grade, 4);
            RequestValidator.ValidateMinValue("grade", this.Grade, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
