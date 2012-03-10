using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.previewurl.get
    /// </summary>
    public class TaohuaPreviewurlGetRequest : ITopRequest<TaohuaPreviewurlGetResponse>
    {
        /// <summary>
        /// 用来区分要预览的文档类型,目前支持两种  pre_epub 预览epub文档  pre_pdf  预览pdf文档
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 文件位置
        /// </summary>
        public string Position { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.previewurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("file_type", this.FileType);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("position", this.Position);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("file_type", this.FileType);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("position", this.Position);
        }

        #endregion
    }
}
