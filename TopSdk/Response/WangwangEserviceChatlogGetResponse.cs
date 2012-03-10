using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceChatlogGetResponse.
    /// </summary>
    public class WangwangEserviceChatlogGetResponse : TopResponse
    {
        /// <summary>
        /// 聊天记录数目。
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 聊天消息列表，即Msg[]，direction=0为from_id发送消息给to_id，direction=1为to_id发送消息给from_id
        /// </summary>
        [XmlArray("msgs")]
        [XmlArrayItem("msg")]
        public List<Msg> Msgs { get; set; }

        /// <summary>
        /// 返回码：<br>  10000:成功；<br>  50000：时间非法，包括1)时间段超过7天,或2)起始时间距今超过30天，或3)时间格式不对；<br>  40000：聊天用户ID不是该店铺的帐号或子帐号查询主帐号私密联系人的聊天记录；<br>  30000：系统错误，主要是入参时间早与开通聊天记录保存到服务器的时间。包括必填参数为空等<br>
        /// </summary>
        [XmlElement("ret")]
        public long Ret { get; set; }
    }
}
