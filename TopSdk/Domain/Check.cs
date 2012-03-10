using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Check Data Structure.
    /// </summary>
    [Serializable]
    public class Check : TopObject
    {
        /// <summary>
        /// 是否是粉丝
        /// </summary>
        [XmlElement("check")]
        public bool Check_ { get; set; }
    }
}
