using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class AccDetailModel : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 收款方身份认证信息。biz_scene=LOCAL时忽略该参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_info")]
        public CertInfo CertInfo { get; set; }

        /// <summary>
        /// 明细流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_no")]
        public string DetailNo { get; set; }

        /// <summary>
        /// 明细失败错误码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 明细失败错误原因
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 转账币种兑换的汇率信息。biz_scene是LOCAL场景下，该参数返回空。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exchange_rate")]
        public ExchangeRate ExchangeRate { get; set; }

        /// <summary>
        /// 是否需要通过alipay_order_no原单据重试.  T: 需要;  F或为空: 不需要.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_retry")]
        public string NeedRetry { get; set; }

        /// <summary>
        /// 收款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_info")]
        public AccPayeeInfo PayeeInfo { get; set; }

        /// <summary>
        /// 应付金额. 付款方应付金额.  LOCAL场景下为空.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付币种.付款方应付的币种, 与批次请求时的payment_currency相同.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_currency")]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 结算金额。  收款方实际收到的金额.  biz_scene是LOCAL场景下，该参数返回空。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_amount")]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// 结算币种.收款方收到的币种. LOCAL场景下为空.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_currency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// INIT：初始  APPLIED：已下单  DEALED：处理中  SUCCESS：处理成功  DISUSE：已废除  FAIL：处理失败  UNKNOWN：未知状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 转账金额。代发请求中指定的trans_amount.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 转账币种
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
