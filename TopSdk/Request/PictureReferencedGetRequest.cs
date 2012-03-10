using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.referenced.get
    /// </summary>
    public class PictureReferencedGetRequest : ITopRequest<PictureReferencedGetResponse>
    {
        /// <summary>
        /// 图片id
        /// </summary>
        public Nullable<long> PictureId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.referenced.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("picture_id", this.PictureId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("picture_id", this.PictureId);
        }

        #endregion
    }
}
