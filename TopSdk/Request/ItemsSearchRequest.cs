using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.search
    /// </summary>
    public class ItemsSearchRequest : ITopRequest<ItemsSearchResponse>
    {
        /// <summary>
        /// 商品是否为虚拟商品  true：是虚拟商品  false：不是虚拟商品
        /// </summary>
        public Nullable<bool> AuctionFlag { get; set; }

        /// <summary>
        /// 商品是否为自动发货  true：自动发货  false：非自动发货
        /// </summary>
        public Nullable<bool> AutoPost { get; set; }

        /// <summary>
        /// 商品所属类目Id。ItemCat中的cid。 可以通过taobao.itemcats.get取到
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 商品最高价格。单位:元。正整数，取值范围:0-100000000
        /// </summary>
        public Nullable<long> EndPrice { get; set; }

        /// <summary>
        /// 商品所属卖家的最大信用等级数，1表示1心，2表示2心……，设置此条件表示搜索结果里的商品，所属的卖家信用必须小于等于设置的end_score
        /// </summary>
        public Nullable<long> EndScore { get; set; }

        /// <summary>
        /// 商品30天内最大销售数，设置此条件表示搜索结果里的商品，最近成交量必须小于等于设置的end_volume
        /// </summary>
        public Nullable<long> EndVolume { get; set; }

        /// <summary>
        /// 需返回的商品结构字段列表。可选值为Item中的以下字段：num_iid,title,nick,pic_url,cid,price,type,delist_time,post_fee；多个字段之间用“,” 分隔。如：iid,title。新增字段location（卖家地址，可以分别获取location.city,location.state）；score(卖家信用等级数),volume(最近成交量) 新增字段：has_discount, num, is_prepay, promoted_service, ww_status, list_time
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 是否正品保障商品(既是如实描述，又是7天无理由退换货的商品，设置了这个属性时：is_prepay和promoted_service不能再行设置)，设置为true表示该商品是正品保障的商品，设置为false或不设置表示不判断这个属性
        /// </summary>
        public Nullable<bool> GenuineSecurity { get; set; }

        /// <summary>
        /// 商品是否对会员打折
        /// </summary>
        public Nullable<bool> HasDiscount { get; set; }

        /// <summary>
        /// 是否是3D淘宝的商品,置为false或为空表示不对是否3D商品进行判断
        /// </summary>
        public Nullable<bool> Is3D { get; set; }

        /// <summary>
        /// 是否支持货到付款，设置为true表示支持货到付款，设置为false或不设置表示不判断这个属性
        /// </summary>
        public Nullable<bool> IsCod { get; set; }

        /// <summary>
        /// 表示是否搜索商城的商品这一搜索条件。 值含义：true：搜索商城商品，false：搜素集市商品，若为null，则搜索全部的商品（默认值）
        /// </summary>
        public Nullable<bool> IsMall { get; set; }

        /// <summary>
        /// 是否如实描述(即:先行赔付)商品，设置为true表示该商品是如实描述的商品，设置为false或不设置表示不判断这个属性
        /// </summary>
        public Nullable<bool> IsPrepay { get; set; }

        /// <summary>
        /// 表示是否新品这一搜索条件。 值含义：true-是新品，false-无限制，不输入(null)-无限制
        /// </summary>
        public Nullable<bool> IsXinpin { get; set; }

        /// <summary>
        /// 所在市。如：杭州
        /// </summary>
        public string LocationCity { get; set; }

        /// <summary>
        /// 所在省。如：浙江
        /// </summary>
        public string LocationState { get; set; }

        /// <summary>
        /// 卖家昵称列表。多个之间用“,”分隔；最多支持5个卖家昵称。如:nick1,nick2,nick3。
        /// </summary>
        public string Nicks { get; set; }

        /// <summary>
        /// 是否淘1站代购商品，设置为true表示淘1站商品，设置为false或不设置表示不判断这个属性
        /// </summary>
        public Nullable<bool> OneStation { get; set; }

        /// <summary>
        /// 排序方式。格式为column:asc/desc,column可选值为: price, delist_time, seller_credit；如按价格升序排列表示为：price:asc。新增排序字段：volume（最近成交量）；新增排序字段：popularity(商品的人气值)
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数。默认值为1,即默认返回第一页数据。用此接口获取数据时，当翻页获取的条数（page_no*page_size）超过10240,为了保护后台搜索引擎，接口将报错。所以请大家尽可能的细化自己的搜索条件，例如根据修改时间分段获取商品
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。取值范围:大于零的整数;最大值：200；默认值：40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 免运费（不设置或设置为false为包含所有邮费状态，设置为true结果只有卖家包邮的商品）不能单独使用，要和其他条件一起用才行。
        /// </summary>
        public Nullable<bool> PostFree { get; set; }

        /// <summary>
        /// 可以根据产品Id搜索属于这个spu的商品。这个字段可以通过查询 taobao.products.get 取到
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 是否提供保障服务的商品。可选入参有：2、4。设置为2表示该商品是“假一赔三”的商品，设置为4表示该商品是“7天无理由退换货”的商品
        /// </summary>
        public string PromotedService { get; set; }

        /// <summary>
        /// 商品属性。商品属性。可以搜到拥有和输入属性一样的商品列表。字段格式为：pid1:vid1;pid2:vid2.属性的pid调用 taobao.itemprops.get.v2取得，属性值的vid用taobao.itempropvalues.get取得vid。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 搜索字段。 用来搜索商品的title以及对应产品的title。
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// 商品最低价格。单位:元。正整数，取值范围:0-100000000。
        /// </summary>
        public Nullable<long> StartPrice { get; set; }

        /// <summary>
        /// 商品所属卖家的最小信用等级数，1表示1心，2表示2心……，设置此条件表示搜索结果里的商品，所属的卖家信用必须大于等于设置的 start_score。
        /// </summary>
        public Nullable<long> StartScore { get; set; }

        /// <summary>
        /// 商品30天内最小销售数，设置此条件表示搜索结果里的商品，最近成交量必须大于等于设置的start_volume。
        /// </summary>
        public Nullable<long> StartVolume { get; set; }

        /// <summary>
        /// 商品的新旧状态。可选入参有：new、second、unused 。设置为new表示该商品是全新的商品，设置为second表示该商品是二手的商品，设置为unused表示该商品是闲置的商品
        /// </summary>
        public string StuffStatus { get; set; }

        /// <summary>
        /// 旺旺在线状态（不设置结果包含所有状态，设置为true结果只有旺旺在线卖家的商品）不能单独使用，要和其他条件一起用才行。
        /// </summary>
        public Nullable<bool> WwStatus { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auction_flag", this.AuctionFlag);
            parameters.Add("auto_post", this.AutoPost);
            parameters.Add("cid", this.Cid);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("end_score", this.EndScore);
            parameters.Add("end_volume", this.EndVolume);
            parameters.Add("fields", this.Fields);
            parameters.Add("genuine_security", this.GenuineSecurity);
            parameters.Add("has_discount", this.HasDiscount);
            parameters.Add("is_3D", this.Is3D);
            parameters.Add("is_cod", this.IsCod);
            parameters.Add("is_mall", this.IsMall);
            parameters.Add("is_prepay", this.IsPrepay);
            parameters.Add("is_xinpin", this.IsXinpin);
            parameters.Add("location.city", this.LocationCity);
            parameters.Add("location.state", this.LocationState);
            parameters.Add("nicks", this.Nicks);
            parameters.Add("one_station", this.OneStation);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("post_free", this.PostFree);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("promoted_service", this.PromotedService);
            parameters.Add("props", this.Props);
            parameters.Add("q", this.Q);
            parameters.Add("start_price", this.StartPrice);
            parameters.Add("start_score", this.StartScore);
            parameters.Add("start_volume", this.StartVolume);
            parameters.Add("stuff_status", this.StuffStatus);
            parameters.Add("ww_status", this.WwStatus);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("cid", this.Cid, 0);
            RequestValidator.ValidateMinValue("end_price", this.EndPrice, 0);
            RequestValidator.ValidateMinValue("end_score", this.EndScore, 0);
            RequestValidator.ValidateMinValue("end_volume", this.EndVolume, 0);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMinValue("product_id", this.ProductId, 0);
            RequestValidator.ValidateMinValue("start_price", this.StartPrice, 0);
            RequestValidator.ValidateMinValue("start_score", this.StartScore, 0);
            RequestValidator.ValidateMinValue("start_volume", this.StartVolume, 0);
        }

        #endregion
    }
}
