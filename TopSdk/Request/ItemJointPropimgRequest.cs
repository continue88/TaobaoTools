using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.joint.propimg
    /// </summary>
    public class ItemJointPropimgRequest : ITopRequest<ItemJointPropimgResponse>
    {
        /// <summary>
        /// 属性图片ID。如果是新增不需要填写
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 商品数字ID，必选
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 图片序号
        /// </summary>
        public Nullable<long> Position { get; set; }

        /// <summary>
        /// 属性列表。调用taobao.itemprops.get.v2获取类目属性，属性必须是颜色属性，再用taobao.itempropvalues.get取得vid。格式:pid:vid。
        /// </summary>
        public string Properties { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.joint.propimg";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("pic_path", this.PicPath);
            parameters.Add("position", this.Position);
            parameters.Add("properties", this.Properties);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
            RequestValidator.ValidateMinValue("num_iid", this.NumIid, 0);
            RequestValidator.ValidateRequired("pic_path", this.PicPath);
            RequestValidator.ValidateRequired("properties", this.Properties);
        }

        #endregion
    }
}
