using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeFastpayEteDidiPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeFastpayEteDidiPayModel : AopObject
    {
        /// <summary>
        /// 对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 付款支付宝用户登录ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 付款支付宝用户登录密码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login_passwd")]
        public string LoginPasswd { get; set; }

        /// <summary>
        /// 外部商户异步通知地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mc_notify_url")]
        public string McNotifyUrl { get; set; }

        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 付款支付宝用户支付密码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_passwd")]
        public string PayPasswd { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 收款支付宝用户ID。 如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 商品的标题/交易标题/订单标题/订单关键字等。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 该笔订单的资金总额，单位为RMB-Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 付款支付宝用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
