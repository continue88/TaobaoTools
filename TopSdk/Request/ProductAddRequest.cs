using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.add
    /// </summary>
    public class ProductAddRequest : ITopUploadRequest<ProductAddResponse>
    {
        /// <summary>
        /// 非关键属性结构:pid:vid;pid:vid.非关键属性不包含关键属性、销售属性、用户自定义属性、商品属性;调用taobao.itemprops.get获取pid,调用taobao.itempropvalues.get获取vid.<br><font color=red>注:支持最大长度为512字节</font>
        /// </summary>
        public string Binds { get; set; }

        /// <summary>
        /// 商品类目ID.调用taobao.itemcats.get获取;注意:必须是叶子类目 id.
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 用户自定义属性,结构：pid1:value1;pid2:value2，如果有型号，系列,货号等用: 隔开 例如：“20000:优衣库:型号:001:632501:1234”，表示“品牌:优衣库:型号:001:货号:1234”
        /// </summary>
        public string CustomerProps { get; set; }

        /// <summary>
        /// 产品描述.最大25000个字节
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 产品主图片.最大1M,目前仅支持GIF,JPG.
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 是不是主图
        /// </summary>
        public Nullable<bool> Major { get; set; }

        /// <summary>
        /// 上市时间。目前只支持鞋城类目传入此参数
        /// </summary>
        public Nullable<DateTime> MarketTime { get; set; }

        /// <summary>
        /// 产品名称,最大60个字节.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 外部产品ID
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 产品市场价.精确到2位小数;单位为元.如：200.07
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 销售属性值别名。格式为pid1:vid1:alias1;pid1:vid2:alia2。只有少数销售属性值支持传入别名，比如颜色和尺寸
        /// </summary>
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 关键属性 结构:pid:vid;pid:vid.调用taobao.itemprops.get获取pid,调用taobao.itempropvalues.get获取vid;如果碰到用户自定义属性,请用customer_props.
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 销售属性结构:pid:vid;pid:vid.调用taobao.itemprops.get获取is_sale_prop＝true的pid,调用taobao.itempropvalues.get获取vid.
        /// </summary>
        public string SaleProps { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("binds", this.Binds);
            parameters.Add("cid", this.Cid);
            parameters.Add("customer_props", this.CustomerProps);
            parameters.Add("desc", this.Desc);
            parameters.Add("major", this.Major);
            parameters.Add("market_time", this.MarketTime);
            parameters.Add("name", this.Name);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("price", this.Price);
            parameters.Add("property_alias", this.PropertyAlias);
            parameters.Add("props", this.Props);
            parameters.Add("sale_props", this.SaleProps);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("binds", this.Binds, 512);
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateRequired("image", this.Image);
            RequestValidator.ValidateMaxLength("image", this.Image, 1048576);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("price", this.Price);
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
