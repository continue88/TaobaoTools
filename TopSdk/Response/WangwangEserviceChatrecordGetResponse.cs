using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceChatrecordGetResponse.
    /// </summary>
    public class WangwangEserviceChatrecordGetResponse : TopResponse
    {
        /// <summary>
        /// 聊天日志文件下载url
        /// </summary>
        [XmlElement("log_file_url")]
        public string LogFileUrl { get; set; }
    }
}
