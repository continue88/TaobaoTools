using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.poster.channel.get
    /// </summary>
    public class PosterChannelGetRequest : ITopRequest<PosterChannelGetResponse>
    {
        /// <summary>
        /// 根据频道ID获取频道信息
        /// </summary>
        public Nullable<long> ChannelId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.poster.channel.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_id", this.ChannelId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("channel_id", this.ChannelId);
        }

        #endregion
    }
}
