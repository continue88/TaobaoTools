using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.image.upload
    /// </summary>
    public class FenxiaoProductImageUploadRequest : ITopUploadRequest<FenxiaoProductImageUploadResponse>
    {
        /// <summary>
        /// 产品图片
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 产品主图图片空间相对路径或绝对路径
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 图片位置，1-5之间
        /// </summary>
        public Nullable<long> Position { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.image.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("pic_path", this.PicPath);
            parameters.Add("position", this.Position);
            parameters.Add("product_id", this.ProductId);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("position", this.Position);
            RequestValidator.ValidateRequired("product_id", this.ProductId);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
