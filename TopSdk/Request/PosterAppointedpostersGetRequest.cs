using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.poster.appointedposters.get
    /// </summary>
    public class PosterAppointedpostersGetRequest : ITopRequest<PosterAppointedpostersGetResponse>
    {
        /// <summary>
        /// HOT(热门），RECOMMEND（推荐）
        /// </summary>
        public string AppointedType { get; set; }

        /// <summary>
        /// 频道ID列表
        /// </summary>
        public string ChannelIds { get; set; }

        /// <summary>
        /// 请求返回的记录数，默认10条，最多20条，如果请求超过20或者小于等于0，则按10条返回
        /// </summary>
        public Nullable<long> ReNum { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.poster.appointedposters.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appointed_type", this.AppointedType);
            parameters.Add("channel_ids", this.ChannelIds);
            parameters.Add("re_num", this.ReNum);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("appointed_type", this.AppointedType);
            RequestValidator.ValidateRequired("channel_ids", this.ChannelIds);
            RequestValidator.ValidateMaxListSize("channel_ids", this.ChannelIds, 15);
        }

        #endregion
    }
}
