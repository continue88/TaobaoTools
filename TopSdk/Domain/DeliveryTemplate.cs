using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// DeliveryTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryTemplate : TopObject
    {
        /// <summary>
        /// 可选值：0,1   说明  0:表示买家承担服务费;  1:表示卖家承担服务费
        /// </summary>
        [XmlElement("assumer")]
        public long Assumer { get; set; }

        /// <summary>
        /// 模板创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 运费模板中运费详细信息对象，包含默认运费和指定地区运费
        /// </summary>
        [XmlArray("fee_list")]
        [XmlArrayItem("top_fee")]
        public List<TopFee> FeeList { get; set; }

        /// <summary>
        /// 模板修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 模板名称，长度不能超过25个字节
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 物流服务模板支持增值服务列表，多个用分号隔开。cod:货到付款 mops：刷卡付款
        /// </summary>
        [XmlElement("supports")]
        public string Supports { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 可选值：0 说明： 0:表示按宝贝件数计算运费
        /// </summary>
        [XmlElement("valuation")]
        public long Valuation { get; set; }
    }
}
