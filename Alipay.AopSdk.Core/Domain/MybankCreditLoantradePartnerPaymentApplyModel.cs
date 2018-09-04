using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradePartnerPaymentApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradePartnerPaymentApplyModel : AopObject
    {
        /// <summary>
        /// 业务金额，单位分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 业务产品编码，64个字符以内
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_product_code")]
        public string BizProductCode { get; set; }

        /// <summary>
        /// 业务类型，目前只支持两种：REPAY（还款）,ENCASH（放款）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 客户支付宝账户，与UID字段不能同时为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("login_account")]
        public string LoginAccount { get; set; }

        /// <summary>
        /// 网商业务订单号,64个字符以内、只能包含字母、数字、下划线；需保证在外部网商端不重复
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mybk_order_no")]
        public string MybkOrderNo { get; set; }

        /// <summary>
        /// 外部平台订单号,64个字符以内、只能包含字母、数字、下划线；需保证在外部平台端不重复
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 扩展参数，JSON格式，100个字符以内，在代收请求时需要附带期数信息在扩展参数中，代付的场景下是没有的,具体参数：tenor:期次
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_param")]
        public string OutParam { get; set; }

        /// <summary>
        /// 外部请求流水号,32个字符以内、只能包含字母、数字、下划线；需保证在外部平台端不重复
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_seq_no")]
        public string OutSeqNo { get; set; }

        /// <summary>
        /// 收款方列表
        /// </summary>
        [XmlArray("payee_account_list")]
        [XmlArrayItem("payment_account_info")]
        public List<PaymentAccountInfo> PayeeAccountList { get; set; }

        /// <summary>
        /// 付款方列表
        /// </summary>
        [XmlArray("payer_account_list")]
        [XmlArrayItem("payment_account_info")]
        public List<PaymentAccountInfo> PayerAccountList { get; set; }

        /// <summary>
        /// 代收付产品编码，64个字符以内
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_product_code")]
        public string PaymentProductCode { get; set; }

        /// <summary>
        /// 客户支付宝账号数字ID，与支付宝账户字段不能同时为空
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
