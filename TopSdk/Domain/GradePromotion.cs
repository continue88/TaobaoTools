using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// GradePromotion Data Structure.
    /// </summary>
    [Serializable]
    public class GradePromotion : TopObject
    {
        /// <summary>
        /// 买家会员级别    1：普通会员 2：高级会员 3：VIP会员 4：至尊VIP
        /// </summary>
        [XmlElement("cur_grade")]
        public string CurGrade { get; set; }

        /// <summary>
        /// 普通会员 、高级会员、VIP会员、至尊VIP
        /// </summary>
        [XmlElement("cur_grade_name")]
        public string CurGradeName { get; set; }

        /// <summary>
        /// 会员级别折扣率没有小数，990代表9.9折
        /// </summary>
        [XmlElement("discount")]
        public long Discount { get; set; }

        /// <summary>
        /// 升级到下一个级别的需要的交易额，单位：分
        /// </summary>
        [XmlElement("next_upgrade_amount")]
        public long NextUpgradeAmount { get; set; }

        /// <summary>
        /// 升级到下一个级别的需要的交易量
        /// </summary>
        [XmlElement("next_upgrade_count")]
        public long NextUpgradeCount { get; set; }
    }
}
