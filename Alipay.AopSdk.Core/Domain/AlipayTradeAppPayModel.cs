using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeAppPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAppPayModel : AopObject
    {
        /// <summary>
        /// 对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 禁用渠道，用户不可用指定渠道支付  当有多个渠道时用“,”分隔  注，与enable_pay_channels互斥
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 可用渠道，用户只能在指定渠道范围内支付  当有多个渠道时用“,”分隔  注，与disable_pay_channels互斥
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_pay_channels")]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// 外部指定买家
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_user_info")]
        public ExtUserInfo ExtUserInfo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_params")]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 商品主类型 :0-虚拟类商品,1-实物类商品
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 开票信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_info")]
        public InvoiceInfo InvoiceInfo { get; set; }

        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则返回给商户时会回传该参数。支付宝只会在同步返回（包括跳转回商户网站）和异步通知时将该参数原样返回。本参数必须进行UrlEncode之后才可以发送给支付宝。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠参数  注：仅与支付宝协商后可用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 描述分账信息，json格式，详见分账参数说明
        /// </summary>
        [Newtonsoft.Json.JsonProperty("royalty_info")]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 收款支付宝用户ID。 如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 描述结算信息，json格式，详见结算参数说明
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 指定渠道，目前仅支持传入pcredit  若由于用户原因渠道不可用，用户可选择是否用其他渠道支付。  注：该参数不可与花呗分期参数同时传入
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specified_channel")]
        public string SpecifiedChannel { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 间连受理商户信息体，当前只对特殊银行机构特定场景下使用此字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_merchant")]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// 商品的标题/交易标题/订单标题/订单关键字等。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 绝对超时时间，格式为yyyy-MM-dd HH:mm。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
