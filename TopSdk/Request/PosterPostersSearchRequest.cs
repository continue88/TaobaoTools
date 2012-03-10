using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.poster.posters.search
    /// </summary>
    public class PosterPostersSearchRequest : ITopRequest<PosterPostersSearchResponse>
    {
        /// <summary>
        /// 频道id列表
        /// </summary>
        public string ChannelIds { get; set; }

        /// <summary>
        /// 编辑推荐：editor_recommend = 1；
        /// </summary>
        public Nullable<long> EditorRecommend { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// 关键词出现在标题，短标题，标签中
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页显示画报数 小于10或者大于20，默认设置为10
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 服饰 频道 {  推荐系数  2  服饰—平铺图;  推荐系数  5 服饰—真人秀;  ;推荐系数  7 服饰—风格秀场;  }  男人 频道{  推荐系数  8 男人频道—卖家画报;  }   女人 频道{  推荐系数 6 女人频道—淘宝红人;  推荐系数 8 女人频道—优质街拍;  }   亲子 频道{  推荐系数 1 亲子频道—亲子单品；  推荐系数 8 亲子频道—卖家画报；  }    美容 频道{  推荐系数 5+关键字:护肤 美容频道—护肤内容；  推荐系数 5+关键字:彩妆 美容频道—彩妆内容；  推荐系数 5+关键字:美发 美容频道—扎发类内容；  }  居家 频道{  推荐系数 5 居家频道—线下体验馆-爱蜂潮；  }
        /// </summary>
        public Nullable<long> RecommendFactor { get; set; }

        /// <summary>
        /// 1："点击升序"；  2："点击降序"；  3："创建时间升序"；  4："创建时间降序"；
        /// </summary>
        public Nullable<long> SortType { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        /// <summary>
        /// 制作画报的 用户名
        /// </summary>
        public string UserNick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.poster.posters.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_ids", this.ChannelIds);
            parameters.Add("editor_recommend", this.EditorRecommend);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("key_word", this.KeyWord);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("recommend_factor", this.RecommendFactor);
            parameters.Add("sort_type", this.SortType);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("user_nick", this.UserNick);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("channel_ids", this.ChannelIds, 20);
            RequestValidator.ValidateMaxLength("channel_ids", this.ChannelIds, 100);
            RequestValidator.ValidateMaxValue("editor_recommend", this.EditorRecommend, 1);
            RequestValidator.ValidateMinValue("editor_recommend", this.EditorRecommend, 1);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("recommend_factor", this.RecommendFactor, 10);
            RequestValidator.ValidateMinValue("recommend_factor", this.RecommendFactor, 0);
            RequestValidator.ValidateMaxValue("sort_type", this.SortType, 4);
            RequestValidator.ValidateMinValue("sort_type", this.SortType, 1);
        }

        #endregion
    }
}
