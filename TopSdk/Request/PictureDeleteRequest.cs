using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.delete
    /// </summary>
    public class PictureDeleteRequest : ITopRequest<PictureDeleteResponse>
    {
        /// <summary>
        /// 图片ID字符串,可以一个也可以一组,用英文逗号间隔,如450,120,155
        /// </summary>
        public string PictureIds { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("picture_ids", this.PictureIds);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("picture_ids", this.PictureIds);
        }

        #endregion
    }
}
