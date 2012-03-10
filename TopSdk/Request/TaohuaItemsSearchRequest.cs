using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.items.search
    /// </summary>
    public class TaohuaItemsSearchRequest : ITopRequest<TaohuaItemsSearchResponse>
    {
        /// <summary>
        /// 文件最小size,单位byte。
        /// </summary>
        public string BeginSize { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 文件最大size,单位byte。
        /// </summary>
        public string EndSize { get; set; }

        /// <summary>
        /// 按照文件类型来搜索
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 是否免费，如果为true则表示只搜索免费的商品。
        /// </summary>
        public Nullable<bool> Free { get; set; }

        /// <summary>
        /// 查询关键字,超过60好字符则自动截断为60个字符.  默认允许为null
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 分页搜索商品信息，page_no代表的是第几页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分页搜索商品信息，page_size代表：每页显示多少条数据。  目前最少5条，最多30条数据。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 排序值:    1. 评分排序：ratescoredesc,  2. 价格升序: priceasc,  3. 价格降序: pricedesc,  4. 时间排序: shelvesdate,  5. 浏览排序：viewcount,  6. 销量升序：saleasc,  7. 默认排序：default,
        /// </summary>
        public string Sort { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.items.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("begin_size", this.BeginSize);
            parameters.Add("cid", this.Cid);
            parameters.Add("end_size", this.EndSize);
            parameters.Add("file_type", this.FileType);
            parameters.Add("free", this.Free);
            parameters.Add("keywords", this.Keywords);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("sort", this.Sort);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 30);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 5);
        }

        #endregion
    }
}
