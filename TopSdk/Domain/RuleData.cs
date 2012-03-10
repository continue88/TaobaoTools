using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// RuleData Data Structure.
    /// </summary>
    [Serializable]
    public class RuleData : TopObject
    {
        /// <summary>
        /// 交易结束时间
        /// </summary>
        [XmlElement("end_trade_time")]
        public string EndTradeTime { get; set; }

        /// <summary>
        /// 会员等级
        /// </summary>
        [XmlElement("grade")]
        public long Grade { get; set; }

        /// <summary>
        /// 分组信息，包括分组id与分组名称
        /// </summary>
        [XmlArray("grouplist")]
        [XmlArrayItem("group_domain")]
        public List<GroupDomain> Grouplist { get; set; }

        /// <summary>
        /// 最大平均客单价
        /// </summary>
        [XmlElement("max_avg_price")]
        public string MaxAvgPrice { get; set; }

        /// <summary>
        /// 最大交易关闭次数
        /// </summary>
        [XmlElement("max_close_trade_count")]
        public long MaxCloseTradeCount { get; set; }

        /// <summary>
        /// 最大宝贝件数
        /// </summary>
        [XmlElement("max_item_count")]
        public long MaxItemCount { get; set; }

        /// <summary>
        /// 最大交易额
        /// </summary>
        [XmlElement("max_trade_amount")]
        public string MaxTradeAmount { get; set; }

        /// <summary>
        /// 最大交易笔数
        /// </summary>
        [XmlElement("max_trade_count")]
        public long MaxTradeCount { get; set; }

        /// <summary>
        /// 最小平均客单价
        /// </summary>
        [XmlElement("min_avg_price")]
        public string MinAvgPrice { get; set; }

        /// <summary>
        /// 最小交易关闭次数
        /// </summary>
        [XmlElement("min_close_trade_count")]
        public long MinCloseTradeCount { get; set; }

        /// <summary>
        /// 最少宝贝件数
        /// </summary>
        [XmlElement("min_item_count")]
        public long MinItemCount { get; set; }

        /// <summary>
        /// 最小交易额
        /// </summary>
        [XmlElement("min_trade_amount")]
        public string MinTradeAmount { get; set; }

        /// <summary>
        /// 最小交易笔数
        /// </summary>
        [XmlElement("min_trade_count")]
        public long MinTradeCount { get; set; }

        /// <summary>
        /// 省份的代码，北京=1,天津=2,河北省=3,山西省=4,内蒙古自治区=5,辽宁省=6,吉林省=7,黑龙江省=8,上海=9,江苏省=10,浙江省=11,安徽省=12,福建省=13,江西省=14,山东省=15,河南省=16,湖北省=17,湖南省=18, 广东省=19,广西壮族自治区=20,海南省=21,重庆=22,四川省=23,贵州省=24,云南省=25,西藏自治区26,陕西省=27,甘肃省=28,青海省=29,宁夏回族自治区=30,新疆维吾尔自治区=31,台湾省=32,香港特别行政区=33,澳门特别行政区=34,海外=35
        /// </summary>
        [XmlElement("province")]
        public long Province { get; set; }

        /// <summary>
        /// 客户关系来源
        /// </summary>
        [XmlElement("relation_source")]
        public long RelationSource { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public long RuleId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 交易的开始时间
        /// </summary>
        [XmlElement("start_trade_time")]
        public string StartTradeTime { get; set; }
    }
}
