using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TransitStepInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransitStepInfo : TopObject
    {
        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 状态发生的时间
        /// </summary>
        [XmlElement("status_time")]
        public string StatusTime { get; set; }
    }
}
