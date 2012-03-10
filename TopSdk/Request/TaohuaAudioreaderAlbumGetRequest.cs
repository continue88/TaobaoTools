using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.audioreader.album.get
    /// </summary>
    public class TaohuaAudioreaderAlbumGetRequest : ITopRequest<TaohuaAudioreaderAlbumGetResponse>
    {
        /// <summary>
        /// 有声读物商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.audioreader.album.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateMinValue("item_id", this.ItemId, 1);
        }

        #endregion
    }
}
