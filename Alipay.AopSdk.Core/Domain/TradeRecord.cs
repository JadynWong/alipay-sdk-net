using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeRecord Data Structure.
    /// </summary>
    [Serializable]
    public class TradeRecord : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 资金流入流程类型,in表示收入,out表示支出
        /// </summary>
        [Newtonsoft.Json.JsonProperty("in_out_type")]
        public string InOutType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单最后修改时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 对方支付宝登录号，需要隐藏
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opposite_logon_id")]
        public string OppositeLogonId { get; set; }

        /// <summary>
        /// 对方姓名，需要隐藏
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opposite_name")]
        public string OppositeName { get; set; }

        /// <summary>
        /// 对方支付宝账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opposite_user_id")]
        public string OppositeUserId { get; set; }

        /// <summary>
        /// 订单来源，为空查询所有来源。淘宝(taobao)，支付宝(alipay)，其它(other)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_from")]
        public string OrderFrom { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单的名称，描述订单的摘要信息，如交易的商品名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 本方支付宝登录号，需要隐藏
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_logon_id")]
        public string OwnerLogonId { get; set; }

        /// <summary>
        /// 本方姓名，需要隐藏
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 本方支付宝账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_user_id")]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 订单服务费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_charge")]
        public string ServiceCharge { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
