using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.huabao.channel.get
    /// </summary>
    public class HuabaoChannelGetRequest : ITopRequest<HuabaoChannelGetResponse>
    {
        /// <summary>
        /// 频道Id
        /// </summary>
        public Nullable<long> ChannelId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.huabao.channel.get";
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
