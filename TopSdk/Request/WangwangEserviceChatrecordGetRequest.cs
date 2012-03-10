using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.eservice.chatrecord.get
    /// </summary>
    public class WangwangEserviceChatrecordGetRequest : ITopRequest<WangwangEserviceChatrecordGetResponse>
    {
        /// <summary>
        /// 截止日期
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// 客服人员id：cntaobao+淘宝nick，例如cntaobaotest
        /// </summary>
        public string ServiceStaffId { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.eservice.chatrecord.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("service_staff_id", this.ServiceStaffId);
            parameters.Add("start_date", this.StartDate);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("service_staff_id", this.ServiceStaffId);
            RequestValidator.ValidateMaxLength("service_staff_id", this.ServiceStaffId, 1920);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
        }

        #endregion
    }
}
