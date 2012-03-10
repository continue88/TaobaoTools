using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.eservice.chatlog.get
    /// </summary>
    public class WangwangEserviceChatlogGetRequest : ITopRequest<WangwangEserviceChatlogGetResponse>
    {
        /// <summary>
        /// 聊天消息终止时间，如2010-03-24
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 聊天消息被查询用户ID：cntaobao+淘宝nick，例如cntaobaotest
        /// </summary>
        public string FromId { get; set; }

        /// <summary>
        /// 聊天消息起始时间，如2010-02-01
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 聊天消息相关方ID：cntaobao+淘宝nick，例如cntaobaotest
        /// </summary>
        public string ToId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.eservice.chatlog.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("from_id", this.FromId);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("to_id", this.ToId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("from_id", this.FromId);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
            RequestValidator.ValidateRequired("to_id", this.ToId);
        }

        #endregion
    }
}
