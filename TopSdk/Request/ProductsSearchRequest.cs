using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.products.search
    /// </summary>
    public class ProductsSearchRequest : ITopRequest<ProductsSearchResponse>
    {
        /// <summary>
        /// 商品类目ID.调用taobao.itemcats.get获取.
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 需返回的字段列表.可选值:Product数据结构中的以下字段:product_id,name,pic_url,cid,props,price,tsc;多个字段之间用","分隔.新增字段status(product的当前状态)
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 页码.传入值为1代表第一页,传入值为2代表第二页,依此类推.默认返回的数据是从第一页开始.
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数.每页返回最多返回100条,默认值为40.
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 属性,属性值的组合.格式:pid:vid;pid:vid;调用taobao.itemprops.get获取类目属性pid   ,再用taobao.itempropvalues.get取得vid.
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 搜索的关键词是用来搜索产品的title以及关键属性值的名称.如:"优衣库 1234",这种用来表示查询优衣库这个品牌下的货号为1234的产品;　注:q,cid和props至少传入一个
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// 想要获取的产品的状态列表，支持多个状态并列获取，多个状态之间用","分隔，最多同时指定5种状态。例如，只获取小二确认的spu传入"3",只要商家确认的传入"0"，既要小二确认又要商家确认的传入"0,3"。目前只支持者两种类型的状态搜索，输入其他状态无效。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 传入值为：3表示3C表示3C垂直市场产品，4表示鞋城垂直市场产品，8表示网游垂直市场产品。一次只能指定一种垂直市场类型
        /// </summary>
        public Nullable<long> VerticalMarket { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.products.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("props", this.Props);
            parameters.Add("q", this.Q);
            parameters.Add("status", this.Status);
            parameters.Add("vertical_market", this.VerticalMarket);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxLength("status", this.Status, 20);
            RequestValidator.ValidateMinValue("vertical_market", this.VerticalMarket, 0);
        }

        #endregion
    }
}
