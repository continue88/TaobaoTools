using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.update
    /// </summary>
    public class ProductUpdateRequest : ITopUploadRequest<ProductUpdateResponse>
    {
        /// <summary>
        /// 非关键属性.调用taobao.itemprops.get获取pid,调用taobao.itempropvalues.get获取vid;格式:pid:vid;pid:vid
        /// </summary>
        public string Binds { get; set; }

        /// <summary>
        /// 产品描述.最大25000个字节
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 产品主图.最大500K,目前仅支持GIF,JPG
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 是否是主图
        /// </summary>
        public Nullable<bool> Major { get; set; }

        /// <summary>
        /// 产品名称.最大60个字节
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 自定义非关键属性
        /// </summary>
        public string NativeUnkeyprops { get; set; }

        /// <summary>
        /// 外部产品ID
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 产品市场价.精确到2位小数;单位为元.如:200.07
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 销售属性.调用taobao.itemprops.get获取pid,调用taobao.itempropvalues.get获取vid;格式:pid:vid;pid:vid
        /// </summary>
        public string SaleProps { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("binds", this.Binds);
            parameters.Add("desc", this.Desc);
            parameters.Add("major", this.Major);
            parameters.Add("name", this.Name);
            parameters.Add("native_unkeyprops", this.NativeUnkeyprops);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("price", this.Price);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sale_props", this.SaleProps);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("image", this.Image, 1048576);
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
