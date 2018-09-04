using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAuthOrderFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAuthOrderFreezeModel : AopObject
    {
        /// <summary>
        /// 需要冻结的金额，单位为：元（人民币），精确到小数点后两位  取值范围：[0.01,100000000.00]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付授权码，25~30开头的长度为16~24位的数字，实际字符串长度以开发者获取的付款码长度为准
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 授权码类型  目前仅支持"bar_code"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code_type")]
        public string AuthCodeType { get; set; }

        /// <summary>
        /// 业务扩展参数，用于商户的特定业务信息的传递，json格式。   1.间联模式必须传入二级商户ID，key为secondaryMerchantId;  2. 当面资金授权业务对应的类目，key为category，value由支付宝分配，酒店业务传 "HOTEL"；  3. 外部商户的门店编号，key为outStoreCode，可选；  4. 外部商户的门店简称，key为outStoreAlias，可选。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 业务订单的简单描述，如商品名称等  长度不超过100个字母或50个汉字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户授权资金订单号 ,不能包含除中文、英文、数字以外的字符，创建后不能修改，需要保证在商户端不重复。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户本次资金操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭该笔订单  取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m  如果为空，默认15m
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_timeout")]
        public string PayTimeout { get; set; }

        /// <summary>
        /// 收款方支付宝账号（Email或手机号），如果收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)同时传递，则以用户号(payee_user_id)为准，如果商户有勾选花呗渠道，收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)不能同时为空。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_logon_id")]
        public string PayeeLogonId { get; set; }

        /// <summary>
        /// 收款方的支付宝唯一用户号,以2088开头的16位纯数字组成，如果非空则会在支付时校验交易的的收款方与此是否一致，如果商户有勾选花呗渠道，收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)不能同时为空。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 销售产品码，后续新接入预授权当面付的业务，本字段取值固定为PRE_AUTH。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户指定的结算币种。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
