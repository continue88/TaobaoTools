using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.memberinfo.update
    /// </summary>
    public class CrmMemberinfoUpdateRequest : ITopRequest<CrmMemberinfoUpdateResponse>
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 会员等级，1：普通客户，2：高级会员，3：高级会员 ，4：至尊vip    只有正常会员才给予升级，对于status 为delete或者blacklist的会员 升级无效
        /// </summary>
        public Nullable<long> Grade { get; set; }

        /// <summary>
        /// 北京=1,天津=2,河北省=3,山西省=4,内蒙古自治区=5,辽宁省=6,吉林省=7,黑龙江省=8,上海=9,江苏省=10,浙江省=11,安徽省=12,福建省=13,江西省=14,山东省=15,河南省=16,湖北省=17,湖南省=18, 广东省=19,广西壮族自治区=20,海南省=21,重庆=22,四川省=23,贵州省=24,云南省=25,西藏自治区=26,陕西省=27,甘肃省=28,青海省=29,宁夏回族自治区=30,新疆维吾尔自治区=31,台湾省=32,香港特别行政区=33,澳门特别行政区=34,海外=35，约定36为清除Province设置
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 用于描述会员的状态，normal表示正常，blacklist表示黑名单，delete表示删除会员(只有潜在未交易成功的会员才能删除)
        /// </summary>
        public string Status { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.memberinfo.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("city", this.City);
            parameters.Add("grade", this.Grade);
            parameters.Add("province", this.Province);
            parameters.Add("status", this.Status);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buyer_nick", this.BuyerNick);
            RequestValidator.ValidateMaxLength("buyer_nick", this.BuyerNick, 32);
            RequestValidator.ValidateMaxValue("grade", this.Grade, 4);
            RequestValidator.ValidateMinValue("grade", this.Grade, 1);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateMaxLength("status", this.Status, 32);
        }

        #endregion
    }
}
