using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Item Data Structure.
    /// </summary>
    [Serializable]
    public class Item : TopObject
    {
        /// <summary>
        /// 售后服务ID,该字段仅在taobao.item.get接口中返回
        /// </summary>
        [XmlElement("after_sale_id")]
        public long AfterSaleId { get; set; }

        /// <summary>
        /// 商品上传后的状态。onsale出售中，instock库中
        /// </summary>
        [XmlElement("approve_status")]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 商城返点比例，为5的倍数，最低0.5%
        /// </summary>
        [XmlElement("auction_point")]
        public long AuctionPoint { get; set; }

        /// <summary>
        /// 代充商品类型。只有少数类目下的商品可以标记上此字段，具体哪些类目可以上传可以通过taobao.itemcat.features.get获得。在代充商品的类目下，不传表示不标记商品类型（交易搜索中就不能通过标记搜到相关的交易了）。可选类型：  time_card(点卡软件代充)  fee_card(话费软件代充)
        /// </summary>
        [XmlElement("auto_fill")]
        public string AutoFill { get; set; }

        /// <summary>
        /// 商品所属的叶子类目 id
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 货到付款运费模板ID
        /// </summary>
        [XmlElement("cod_postage_id")]
        public long CodPostageId { get; set; }

        /// <summary>
        /// Item的发布时间，目前仅供taobao.item.add和taobao.item.get可用
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 下架时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("delist_time")]
        public string DelistTime { get; set; }

        /// <summary>
        /// 商品描述, 字数要大于5个字符，小于25000个字符
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品url
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// ems费用,格式：5.00；单位：元；精确到：分
        /// </summary>
        [XmlElement("ems_fee")]
        public string EmsFee { get; set; }

        /// <summary>
        /// 快递费用,格式：5.00；单位：元；精确到：分
        /// </summary>
        [XmlElement("express_fee")]
        public string ExpressFee { get; set; }

        /// <summary>
        /// 运费承担方式,seller（卖家承担），buyer(买家承担）
        /// </summary>
        [XmlElement("freight_payer")]
        public string FreightPayer { get; set; }

        /// <summary>
        /// 支持会员打折,true/false
        /// </summary>
        [XmlElement("has_discount")]
        public bool HasDiscount { get; set; }

        /// <summary>
        /// 是否有发票,true/false
        /// </summary>
        [XmlElement("has_invoice")]
        public bool HasInvoice { get; set; }

        /// <summary>
        /// 橱窗推荐,true/false
        /// </summary>
        [XmlElement("has_showcase")]
        public bool HasShowcase { get; set; }

        /// <summary>
        /// 是否有保修,true/false
        /// </summary>
        [XmlElement("has_warranty")]
        public bool HasWarranty { get; set; }

        /// <summary>
        /// 加价幅度。如果为0，代表系统代理幅度。  在竞拍中，为了超越上一个出价，会员需要在当前出价上增加金额，这个金额就是加价幅度。卖家在发布宝贝的时候可以自定义加价幅度，也可以让系统自动代理加价。系统自动代理加价的加价幅度随着当前出价金额的增加而增加，我们建议会员使用系统自动代理加价，并请买家在出价前看清楚加价幅度的具体金额。另外需要注意是，此功能只适用于拍卖的商品。  以下是系统自动代理加价幅度表：  当前价（加价幅度 ）  1-40（ 1 ）、41-100（ 2 ）、101-200（5 ）、201-500 （10）、501-1001（15）、001-2000（25）、2001-5000（50）、5001-10000（100）  10001以上         200
        /// </summary>
        [XmlElement("increment")]
        public string Increment { get; set; }

        /// <summary>
        /// 用户自行输入的类目属性ID串。结构："pid1,pid2,pid3"，如："20000"（表示品牌） 注：通常一个类目下用户可输入的关键属性不超过1个。
        /// </summary>
        [XmlElement("input_pids")]
        public string InputPids { get; set; }

        /// <summary>
        /// 用户自行输入的子属性名和属性值，结构:"父属性值;一级子属性名;一级子属性值;二级子属性名;自定义输入值,....",如：“耐克;耐克系列;科比系列;科比系列;2K5”，input_str需要与input_pids一一对应，注：通常一个类目下用户可输入的关键属性不超过1个。所有属性别名加起来不能超过 3999字节。
        /// </summary>
        [XmlElement("input_str")]
        public string InputStr { get; set; }

        /// <summary>
        /// 是否是3D淘宝的商品
        /// </summary>
        [XmlElement("is_3D")]
        public bool Is3D { get; set; }

        /// <summary>
        /// 是否在外部网店显示
        /// </summary>
        [XmlElement("is_ex")]
        public bool IsEx { get; set; }

        /// <summary>
        /// 非分销商品：0，代销：1，经销：2
        /// </summary>
        [XmlElement("is_fenxiao")]
        public long IsFenxiao { get; set; }

        /// <summary>
        /// 是否24小时闪电发货
        /// </summary>
        [XmlElement("is_lightning_consignment")]
        public bool IsLightningConsignment { get; set; }

        /// <summary>
        /// 商品是否为先行赔付  taobao.items.search和taobao.items.vip.search专用
        /// </summary>
        [XmlElement("is_prepay")]
        public bool IsPrepay { get; set; }

        /// <summary>
        /// 是否在淘宝显示
        /// </summary>
        [XmlElement("is_taobao")]
        public bool IsTaobao { get; set; }

        /// <summary>
        /// 是否定时上架商品
        /// </summary>
        [XmlElement("is_timing")]
        public bool IsTiming { get; set; }

        /// <summary>
        /// 虚拟商品的状态字段
        /// </summary>
        [XmlElement("is_virtual")]
        public bool IsVirtual { get; set; }

        /// <summary>
        /// 标示商品是否为新品。  值含义：true-是，false-否。
        /// </summary>
        [XmlElement("is_xinpin")]
        public bool IsXinpin { get; set; }

        /// <summary>
        /// 商品图片列表(包括主图)。fields中只设置item_img可以返回ItemImg结构体中所有字段，如果设置为item_img.id、item_img.url、item_img.position等形式就只会返回相应的字段
        /// </summary>
        [XmlArray("item_imgs")]
        [XmlArrayItem("item_img")]
        public List<ItemImg> ItemImgs { get; set; }

        /// <summary>
        /// 上架时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("list_time")]
        public string ListTime { get; set; }

        /// <summary>
        /// 商品所在地
        /// </summary>
        [XmlElement("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 商品修改时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 商品数字id
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 是否淘1站商品
        /// </summary>
        [XmlElement("one_station")]
        public bool OneStation { get; set; }

        /// <summary>
        /// 商家外部编码(可与商家外部系统对接)
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 商品主图片地址
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 平邮费用,格式：5.00；单位：元；精确到：分
        /// </summary>
        [XmlElement("post_fee")]
        public string PostFee { get; set; }

        /// <summary>
        /// 宝贝所属的运费模板ID，如果没有返回则说明没有使用运费模板
        /// </summary>
        [XmlElement("postage_id")]
        public long PostageId { get; set; }

        /// <summary>
        /// 商品价格，格式：5.00；单位：元；精确到：分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 宝贝所属产品的id(可能为空). 该字段可以通过taobao.products.search 得到
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 消保类型，多个类型以,分割。可取以下值： 2：假一赔三；4：7天无理由退换货；taobao.items.search和taobao.items.vip.search专用
        /// </summary>
        [XmlElement("promoted_service")]
        public string PromotedService { get; set; }

        /// <summary>
        /// 商品属性图片列表。fields中只设置prop_img可以返回PropImg结构体中所有字段，如果设置为prop_img.id、prop_img.url、prop_img.properties、prop_img.position等形式就只会返回相应的字段
        /// </summary>
        [XmlArray("prop_imgs")]
        [XmlArrayItem("prop_img")]
        public List<PropImg> PropImgs { get; set; }

        /// <summary>
        /// 属性值别名,比如颜色的自定义名称
        /// </summary>
        [XmlElement("property_alias")]
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 商品属性 格式：pid:vid;pid:vid
        /// </summary>
        [XmlElement("props")]
        public string Props { get; set; }

        /// <summary>
        /// 商品属性名称。标识着props内容里面的pid和vid所对应的名称。格式为：pid1:vid1:pid_name1:vid_name1;pid2:vid2:pid_name2:vid_name2……(<strong>注：</strong><font color="red">属性名称中的冒号":"被转换为："#cln#";   分号";"被转换为："#scln#" </font>)
        /// </summary>
        [XmlElement("props_name")]
        public string PropsName { get; set; }

        /// <summary>
        /// 商品所属卖家的信用等级数，1表示1心，2表示2心……，只有调用商品搜索:taobao.items.get和taobao.items.search的时候才能返回
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 秒杀商品类型。打上秒杀标记的商品，用户只能下架并不能再上架，其他任何编辑或删除操作都不能进行。如果用户想取消秒杀标记，需要联系小二进行操作。如果秒杀结束需要自由编辑请联系活动负责人（小二）去掉秒杀标记。可选类型  web_only(只能通过web网络秒杀)  wap_only(只能通过wap网络秒杀)  web_and_wap(既能通过web秒杀也能通过wap秒杀)
        /// </summary>
        [XmlElement("second_kill")]
        public string SecondKill { get; set; }

        /// <summary>
        /// 是否承诺退换货服务!
        /// </summary>
        [XmlElement("sell_promise")]
        public bool SellPromise { get; set; }

        /// <summary>
        /// 商品所属的店铺内卖家自定义类目列表
        /// </summary>
        [XmlElement("seller_cids")]
        public string SellerCids { get; set; }

        /// <summary>
        /// <a href="http://open.taobao.com/dev/index.php/Sku">Sku</a>列表。fields中只设置sku可以返回Sku结构体中所有字段，如果设置为sku.sku_id、sku.properties、sku.quantity等形式就只会返回相应的字段
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("sku")]
        public List<Sku> Skus { get; set; }

        /// <summary>
        /// 商品新旧程度(全新:new，闲置:unused，二手：second)
        /// </summary>
        [XmlElement("stuff_status")]
        public string StuffStatus { get; set; }

        /// <summary>
        /// 标识商品减库存的方式  值含义：1-拍下减库存，2-付款减库存。
        /// </summary>
        [XmlElement("sub_stock")]
        public long SubStock { get; set; }

        /// <summary>
        /// 页面模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 商品标题,不能超过60字节
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品类型(fixed:一口价;auction:拍卖)注：取消团购
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 有效期,7或者14（默认是14天）
        /// </summary>
        [XmlElement("valid_thru")]
        public long ValidThru { get; set; }

        /// <summary>
        /// 商品视频列表(目前只支持单个视频关联)。fields中只设置video可以返回Video结构体中所有字段，如果设置为video.id、video.video_id、  video.url等形式就只会返回相应的字段
        /// </summary>
        [XmlArray("videos")]
        [XmlArrayItem("video")]
        public List<Video> Videos { get; set; }

        /// <summary>
        /// 商品是否违规，违规：true , 不违规：false
        /// </summary>
        [XmlElement("violation")]
        public bool Violation { get; set; }

        /// <summary>
        /// 对应搜索商品列表页的最近成交量,只有调用商品搜索:taobao.items.get和taobao.items.search的时候才能返回
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }

        /// <summary>
        /// 不带html标签的desc文本信息，该字段只在taobao.item.get接口中返回
        /// </summary>
        [XmlElement("wap_desc")]
        public string WapDesc { get; set; }

        /// <summary>
        /// 适合wap应用的商品详情url ，该字段只在taobao.item.get接口中返回
        /// </summary>
        [XmlElement("wap_detail_url")]
        public string WapDetailUrl { get; set; }

        /// <summary>
        /// 商品所属的商家的旺旺在线状况，  taobao.items.search和taobao.items.vip.search专用
        /// </summary>
        [XmlElement("ww_status")]
        public bool WwStatus { get; set; }
    }
}
