using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.poster.posterdetail.get
    /// </summary>
    public class PosterPosterdetailGetRequest : ITopRequest<PosterPosterdetailGetResponse>
    {
        /// <summary>
        /// 画报id
        /// </summary>
        public Nullable<long> PosterId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.poster.posterdetail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("poster_id", this.PosterId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("poster_id", this.PosterId);
            RequestValidator.ValidateMaxValue("poster_id", this.PosterId, 2147483646);
            RequestValidator.ValidateMinValue("poster_id", this.PosterId, 1);
        }

        #endregion
    }
}
