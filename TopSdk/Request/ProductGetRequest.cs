using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.get
    /// </summary>
    public class ProductGetRequest : ITopRequest<ProductGetResponse>
    {
        /// <summary>
        /// 商品类目id.调用taobao.itemcats.get获取;必须是叶子类目id,如果没有传product_id,那么cid和props必须要传.
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 需返回的字段列表.可选值:Product数据结构中的所有字段;多个字段之间用","分隔.
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// Product的id.两种方式来查看一个产品:1.传入product_id来查询 2.传入cid和props来查询
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 比如:诺基亚N73这个产品的关键属性列表就是:品牌:诺基亚;型号:N73,对应的PV值就是10005:10027;10006:29729.
        /// </summary>
        public string Props { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("fields", this.Fields);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("props", this.Props);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
        }

        #endregion
    }
}
