using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taohua.itemresurl.get
    /// </summary>
    public class TaohuaItemresurlGetRequest : ITopRequest<TaohuaItemresurlGetResponse>
    {
        /// <summary>
        /// 商品资源的下载文件类型，可选值：1、pdf，2、epub，3、src。  dpf代表下载pdf类型的文件，epub代表下载epub类型的文件，src代表下载源文件
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 因为下载地址涉及到断点续传的功能，所以需要客户端高速服务器端，应该从哪个byte开始返回文件流，那么这个字段作用就是用于告诉服务端从指定位置读取文件流
        /// </summary>
        public string Position { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taohua.itemresurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("file_type", this.FileType);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("position", this.Position);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
        }

        #endregion
    }
}
