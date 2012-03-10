using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Msg Data Structure.
    /// </summary>
    [Serializable]
    public class Msg : TopObject
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// direction=0为from_id发送消息给to_id，direction=1为to_id发送消息给from_id
        /// </summary>
        [XmlElement("direction")]
        public long Direction { get; set; }

        /// <summary>
        /// 消息日期
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
