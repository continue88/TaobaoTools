using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.audioreader.mytracks.get
    /// </summary>
    public class TaohuaAudioreaderMytracksGetRequest : ITopRequest<TaohuaAudioreaderMytracksGetResponse>
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 购买专辑的序列ID
        /// </summary>
        public Nullable<long> SerialId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.audioreader.mytracks.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("serial_id", this.SerialId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("page_no", this.PageNo, 100);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("serial_id", this.SerialId);
        }

        #endregion
    }
}
