using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.audioreader.search
    /// </summary>
    public class TaohuaAudioreaderSearchRequest : ITopRequest<TaohuaAudioreaderSearchResponse>
    {
        /// <summary>
        /// 类目id
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 是否免费，如果为true则表示只搜索免费的商品
        /// </summary>
        public Nullable<bool> Free { get; set; }

        /// <summary>
        /// 查询关键字,超过60个字符则自动截断为60个字符. 允许为空
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 排序值: 1. 评分排序：ratescoredesc, 2. 价格升序：priceasc, 3. 价格降序：pricedesc, 4. 最新发布：shelvesdate, 5. 最多浏览：viewcount, 6. 销量升序：saleasc, 7. 销量降序：saledesc, 8. 最受欢迎：favoritedesc, 9. 默认排序：default
        /// </summary>
        public string Sort { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.audioreader.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("free", this.Free);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("sort", this.Sort);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("page_no", this.PageNo, 100);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
