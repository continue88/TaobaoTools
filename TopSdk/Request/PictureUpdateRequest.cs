using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.update
    /// </summary>
    public class PictureUpdateRequest : ITopRequest<PictureUpdateResponse>
    {
        /// <summary>
        /// 新的图片名，最大长度50字符，不能为空
        /// </summary>
        public string NewName { get; set; }

        /// <summary>
        /// 要更改名字的图片的id
        /// </summary>
        public Nullable<long> PictureId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("new_name", this.NewName);
            parameters.Add("picture_id", this.PictureId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("new_name", this.NewName);
            RequestValidator.ValidateMaxLength("new_name", this.NewName, 50);
            RequestValidator.ValidateRequired("picture_id", this.PictureId);
        }

        #endregion
    }
}
