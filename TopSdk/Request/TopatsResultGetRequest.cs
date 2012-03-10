using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.result.get
    /// </summary>
    public class TopatsResultGetRequest : ITopRequest<TopatsResultGetResponse>
    {
        /// <summary>
        /// 任务id号，创建任务时返回的task_id
        /// </summary>
        public Nullable<long> TaskId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.result.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("task_id", this.TaskId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("task_id", this.TaskId);
        }

        #endregion
    }
}
