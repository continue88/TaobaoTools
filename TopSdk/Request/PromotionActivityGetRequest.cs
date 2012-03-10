using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.activity.get
    /// </summary>
    public class PromotionActivityGetRequest : ITopRequest<PromotionActivityGetResponse>
    {
        /// <summary>
        /// 活动的id
        /// </summary>
        public Nullable<long> ActivityId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.activity.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("activity_id", this.ActivityId);
            return parameters;
        }

        public void Validate()
        {
        }

        #endregion
    }
}
