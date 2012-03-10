using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.huabao.specialposters.get
    /// </summary>
    public class HuabaoSpecialpostersGetRequest : ITopRequest<HuabaoSpecialpostersGetResponse>
    {
        /// <summary>
        /// 频道Id
        /// </summary>
        public string ChannelIds { get; set; }

        /// <summary>
        /// 返回的记录数，默认10条，最多20条，如果请求超过20或者小于等于10，则按10条返回 type为NEW时该参数无效,返回为指定频道的最新的一条记录
        /// </summary>
        public Nullable<long> Number { get; set; }

        /// <summary>
        /// 类型可选：HOT(热门），RECOMMEND（推荐），NEW（最新）
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.huabao.specialposters.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_ids", this.ChannelIds);
            parameters.Add("number", this.Number);
            parameters.Add("type", this.Type);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("channel_ids", this.ChannelIds);
            RequestValidator.ValidateMaxListSize("channel_ids", this.ChannelIds, 15);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
