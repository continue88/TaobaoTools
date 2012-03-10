using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.audioreader.tracks.get
    /// </summary>
    public class TaohuaAudioreaderTracksGetRequest : ITopRequest<TaohuaAudioreaderTracksGetResponse>
    {
        /// <summary>
        /// 有声读物专辑ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.audioreader.tracks.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateMinValue("item_id", this.ItemId, 1);
            RequestValidator.ValidateMaxValue("page_no", this.PageNo, 100);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
