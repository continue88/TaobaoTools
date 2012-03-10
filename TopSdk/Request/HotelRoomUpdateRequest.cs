using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.room.update
    /// </summary>
    public class HotelRoomUpdateRequest : ITopUploadRequest<HotelRoomUpdateResponse>
    {
        /// <summary>
        /// 面积。可选值：A,B,C,D。分别代表：  A：15平米以下，B：16－30平米，C：31－50平米，D：50平米以上
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 宽带服务。A,B,C,D。分别代表：  A：无宽带，B：免费宽带，C：收费宽带，D：部分收费宽带
        /// </summary>
        public string Bbn { get; set; }

        /// <summary>
        /// 床型。可选值：A,B,C,D,E,F,G,H,I。分别代表：A：单人床，B：大床，C：双床，D：双床/大床，E：子母床，F：上下床，G：圆形床，H：多床，I：其他床型
        /// </summary>
        public string BedType { get; set; }

        /// <summary>
        /// 早餐。A,B,C,D,E。分别代表：  A：无早，B：单早，C：双早，D：三早，E：多早
        /// </summary>
        public string Breakfast { get; set; }

        /// <summary>
        /// 订金。0～99999900的正整数。在payment_type为订金时必须输入，存储的单位是分。不能带角分。
        /// </summary>
        public Nullable<long> Deposit { get; set; }

        /// <summary>
        /// 商品描述。不能超过25000个汉字（50000个字符）。
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 手续费。0～99999900的正整数。在payment_type为手续费或手续费/间夜时必须输入，存储的单位是分。不能带角分。
        /// </summary>
        public Nullable<long> Fee { get; set; }

        /// <summary>
        /// 酒店房间商品gid。必须为数字。
        /// </summary>
        public Nullable<long> Gid { get; set; }

        /// <summary>
        /// 购买须知。不能超过4000个汉字（8000个字符）。
        /// </summary>
        public string Guide { get; set; }

        /// <summary>
        /// 支付类型。可选值：A,B,C,D。分别代表：  A：全额支付，B：手续费，C：订金，D：手续费/间夜
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// 酒店商品图片。类型:JPG,GIF;最大长度:500K。支持的文件类型：gif,jpg,jpeg,png。更新的时候只能更新一张图片，此图片覆盖原有所有图片。如果不传则使用原有所有图片。  如需再发图片，需要调用商品图片上传接口，1个商品最多5张图片。
        /// </summary>
        public FileItem Pic { get; set; }

        /// <summary>
        /// 商品主图需要关联的图片空间的相对url。这个url所对应的图片必须要属于当前用户。pic_path和image只需要传入一个,如果两个都传，默认选择pic_path
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 房态信息。可以传今天开始90天内的房态信息。日期必须连续。JSON格式传递。  date：代表房态日期，格式为YYYY-MM-DD，  price：代表当天房价，0～99999900，存储的单位是分，不能带角分  num：代表当天可售间数，0～999。  如：  [{"date":2011-01-28,"price":10000, "num":10},{"date":2011-01-29,"price":12000,"num":10}]
        /// </summary>
        public string RoomQuotas { get; set; }

        /// <summary>
        /// 设施服务。JSON格式。  value值true有此服务，false没有。  bar：吧台，catv：有线电视，ddd：国内长途电话，idd：国际长途电话，toilet：独立卫生间，pubtoliet：公共卫生间。  如：  {"bar":false,"catv":false,"ddd":false,"idd":false,"pubtoilet":false,"toilet":false}
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// 床宽。可选值：A,B,C,D,E,F,G,H。分别代表：A：1米及以下，B：1.1米，C：1.2米，D：1.35米，E：1.5米，F：1.8米，G：2米，H：2.2米及以上
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 状态。可选值1，2，3。1：上架。2：下架。3：删除。传入相应状态代表去执行相应的操作。
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 楼层。长度不超过8
        /// </summary>
        public string Storey { get; set; }

        /// <summary>
        /// 酒店商品名称。不能超过60字节
        /// </summary>
        public string Title { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.room.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("bbn", this.Bbn);
            parameters.Add("bed_type", this.BedType);
            parameters.Add("breakfast", this.Breakfast);
            parameters.Add("deposit", this.Deposit);
            parameters.Add("desc", this.Desc);
            parameters.Add("fee", this.Fee);
            parameters.Add("gid", this.Gid);
            parameters.Add("guide", this.Guide);
            parameters.Add("payment_type", this.PaymentType);
            parameters.Add("pic_path", this.PicPath);
            parameters.Add("room_quotas", this.RoomQuotas);
            parameters.Add("service", this.Service);
            parameters.Add("size", this.Size);
            parameters.Add("status", this.Status);
            parameters.Add("storey", this.Storey);
            parameters.Add("title", this.Title);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("area", this.Area, 1);
            RequestValidator.ValidateMaxLength("bbn", this.Bbn, 1);
            RequestValidator.ValidateMaxLength("bed_type", this.BedType, 1);
            RequestValidator.ValidateMaxLength("breakfast", this.Breakfast, 1);
            RequestValidator.ValidateMaxValue("deposit", this.Deposit, 99999900);
            RequestValidator.ValidateMinValue("deposit", this.Deposit, 0);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 50000);
            RequestValidator.ValidateMaxValue("fee", this.Fee, 99999900);
            RequestValidator.ValidateMinValue("fee", this.Fee, 0);
            RequestValidator.ValidateRequired("gid", this.Gid);
            RequestValidator.ValidateMaxLength("guide", this.Guide, 8000);
            RequestValidator.ValidateMaxLength("payment_type", this.PaymentType, 1);
            RequestValidator.ValidateMaxLength("pic", this.Pic, 512000);
            RequestValidator.ValidateMaxLength("size", this.Size, 1);
            RequestValidator.ValidateMaxLength("storey", this.Storey, 8);
            RequestValidator.ValidateMaxLength("title", this.Title, 60);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("pic", this.Pic);
            return parameters;
        }

        #endregion
    }
}
