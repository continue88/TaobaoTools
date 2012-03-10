using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.rule.add
    /// </summary>
    public class CrmRuleAddRequest : ITopRequest<CrmRuleAddResponse>
    {
        /// <summary>
        /// 会员等级，可选值为：1,2,3,4
        /// </summary>
        public Nullable<long> Grade { get; set; }

        /// <summary>
        /// 规则应用分组集合，若分组上有任务，则该分组不能挂到该规则下
        /// </summary>
        public string GroupIds { get; set; }

        /// <summary>
        /// 最大平均客单价，单位为元
        /// </summary>
        public string MaxAvgPrice { get; set; }

        /// <summary>
        /// 最大交易关闭数
        /// </summary>
        public Nullable<long> MaxCloseTradeNum { get; set; }

        /// <summary>
        /// 最大宝贝件数
        /// </summary>
        public Nullable<long> MaxItemNum { get; set; }

        /// <summary>
        /// 最迟交易时间
        /// </summary>
        public Nullable<DateTime> MaxLastTradeTime { get; set; }

        /// <summary>
        /// 最大交易金额，单位为元
        /// </summary>
        public string MaxTradeAmount { get; set; }

        /// <summary>
        /// 最大交易数
        /// </summary>
        public Nullable<long> MaxTradeCount { get; set; }

        /// <summary>
        /// 最小平均客单价，单位元
        /// </summary>
        public string MinAvgPrice { get; set; }

        /// <summary>
        /// 最少交易关闭数
        /// </summary>
        public Nullable<long> MinCloseTradeNum { get; set; }

        /// <summary>
        /// 最少宝贝件数
        /// </summary>
        public Nullable<long> MinItemNum { get; set; }

        /// <summary>
        /// 最早交易日期  必须为早于今天的某个时间，例如今天是2011-11-11，那么必须填写2011-11-10或者早于此日期的时间
        /// </summary>
        public Nullable<DateTime> MinLastTradeTime { get; set; }

        /// <summary>
        /// 最小交易金额,单位元。
        /// </summary>
        public string MinTradeAmount { get; set; }

        /// <summary>
        /// 最小交易次数
        /// </summary>
        public Nullable<long> MinTradeCount { get; set; }

        /// <summary>
        /// 北京=1,天津=2,河北省=3,山西省=4,内蒙古自治区=5,辽宁省=6,吉林省=7,黑龙江省=8,上海=9,江苏省=10,浙江省=11,安徽省=12,福建省=13,江西省=14,山东省=15,河南省=16,湖北省=17,湖南省=18, 广东省=19,广西壮族自治区=20,海南省=21,重庆=22,四川省=23,贵州省=24,云南省=25,西藏自治区26,陕西省=27,甘肃省=28,青海省=29,宁夏回族自治区=30,新疆维吾尔自治区=31,台湾省=32,香港特别行政区=33,澳门特别行政区=34,海外=35
        /// </summary>
        public Nullable<long> Province { get; set; }

        /// <summary>
        /// 客户关系来源,可选值为:1,2
        /// </summary>
        public Nullable<long> RelationSource { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        public string RuleName { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.rule.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("grade", this.Grade);
            parameters.Add("group_ids", this.GroupIds);
            parameters.Add("max_avg_price", this.MaxAvgPrice);
            parameters.Add("max_close_trade_num", this.MaxCloseTradeNum);
            parameters.Add("max_item_num", this.MaxItemNum);
            parameters.Add("max_last_trade_time", this.MaxLastTradeTime);
            parameters.Add("max_trade_amount", this.MaxTradeAmount);
            parameters.Add("max_trade_count", this.MaxTradeCount);
            parameters.Add("min_avg_price", this.MinAvgPrice);
            parameters.Add("min_close_trade_num", this.MinCloseTradeNum);
            parameters.Add("min_item_num", this.MinItemNum);
            parameters.Add("min_last_trade_time", this.MinLastTradeTime);
            parameters.Add("min_trade_amount", this.MinTradeAmount);
            parameters.Add("min_trade_count", this.MinTradeCount);
            parameters.Add("province", this.Province);
            parameters.Add("relation_source", this.RelationSource);
            parameters.Add("rule_name", this.RuleName);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("grade", this.Grade, 4);
            RequestValidator.ValidateMinValue("grade", this.Grade, 1);
            RequestValidator.ValidateMaxListSize("group_ids", this.GroupIds, 10);
            RequestValidator.ValidateMaxLength("max_avg_price", this.MaxAvgPrice, 7);
            RequestValidator.ValidateMinValue("max_close_trade_num", this.MaxCloseTradeNum, 0);
            RequestValidator.ValidateMinValue("max_item_num", this.MaxItemNum, 0);
            RequestValidator.ValidateMaxLength("max_trade_amount", this.MaxTradeAmount, 7);
            RequestValidator.ValidateMinValue("max_trade_count", this.MaxTradeCount, 0);
            RequestValidator.ValidateMaxLength("min_avg_price", this.MinAvgPrice, 7);
            RequestValidator.ValidateMinValue("min_close_trade_num", this.MinCloseTradeNum, 0);
            RequestValidator.ValidateMinValue("min_item_num", this.MinItemNum, 0);
            RequestValidator.ValidateMaxLength("min_trade_amount", this.MinTradeAmount, 7);
            RequestValidator.ValidateMinValue("min_trade_count", this.MinTradeCount, 0);
            RequestValidator.ValidateMaxValue("province", this.Province, 35);
            RequestValidator.ValidateMinValue("province", this.Province, 1);
            RequestValidator.ValidateMaxValue("relation_source", this.RelationSource, 2);
            RequestValidator.ValidateMinValue("relation_source", this.RelationSource, 1);
            RequestValidator.ValidateRequired("rule_name", this.RuleName);
            RequestValidator.ValidateMaxLength("rule_name", this.RuleName, 15);
        }

        #endregion
    }
}
