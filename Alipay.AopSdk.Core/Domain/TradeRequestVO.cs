using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeRequestVO Data Structure.
    /// </summary>
    [Serializable]
    public class TradeRequestVO : AopObject
    {
        /// <summary>
        /// globalnet收单机构
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquirer")]
        public string Acquirer { get; set; }

        /// <summary>
        /// 收单成员id(gn站点成员编号）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquirer_mem_id")]
        public string AcquirerMemId { get; set; }

        /// <summary>
        /// 反洗钱处理标志
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aml_status")]
        public string AmlStatus { get; set; }

        /// <summary>
        /// 业务事件码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 交易请求发起时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_advice_timestamp")]
        public string ClientAdviceTimestamp { get; set; }

        /// <summary>
        /// 接入平台业务订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_business_id")]
        public string ClientBusinessId { get; set; }

        /// <summary>
        /// 用于定义FX交易的客户，由购结汇中心统一分配
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 接入平台唯一序列号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_message_id")]
        public string ClientMessageId { get; set; }

        /// <summary>
        /// 客户请求序号:  客户侧的流水号，由客户上送
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_ref")]
        public string ClientRef { get; set; }

        /// <summary>
        /// 接入平台
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_system")]
        public string ClientSystem { get; set; }

        /// <summary>
        /// 端到端传递的事件代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cnl_ev_code")]
        public string CnlEvCode { get; set; }

        /// <summary>
        /// 端到端流水号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cnl_no")]
        public string CnlNo { get; set; }

        /// <summary>
        /// 端到端传递的产品代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cnl_pd_code")]
        public string CnlPdCode { get; set; }

        /// <summary>
        /// 对应金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contra_amount")]
        public string ContraAmount { get; set; }

        /// <summary>
        /// 对应币种
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contra_ccy")]
        public string ContraCcy { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 机构实体
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_entity")]
        public string InstEntity { get; set; }

        /// <summary>
        /// 是否锁价,字典N否，Y是
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_locked")]
        public string IsLocked { get; set; }

        /// <summary>
        /// globalnet发卡机构
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// 发卡成员id(gn站点成员编号）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issuer_mem_id")]
        public string IssuerMemId { get; set; }

        /// <summary>
        /// 商户MCC代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_mcc")]
        public string MerchantMcc { get; set; }

        /// <summary>
        /// 请求类型： T - TradeAdvise。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 操作动作类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 是否可部分成交,字典：Y，N。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partial_trade")]
        public string PartialTrade { get; set; }

        /// <summary>
        /// 交易商户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_provider")]
        public string PaymentProvider { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 对客产品ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 客户协议扩展号，用于支持同一客户在不同场景下所需的汇率模式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profile_id")]
        public string ProfileId { get; set; }

        /// <summary>
        /// 请求汇率基准币种
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate_base_ccy")]
        public string RateBaseCcy { get; set; }

        /// <summary>
        /// 汇率的唯一编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate_ref")]
        public string RateRef { get; set; }

        /// <summary>
        /// 汇率请求模式,字典：  REQ - 按客户请求(含滑点)成交，若该价格失效，则交易失败；  ACP - 汇率失效或请求中不带汇率，接受该客户协议的最新汇率，实际成交汇率以GlobalFX为准；  MAN- 无论如何都受理请求汇率
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate_request_mode")]
        public string RateRequestMode { get; set; }

        /// <summary>
        /// 汇率类型，字典：SPOT，FORWARD，SWAP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// 备用字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reference_field1")]
        public string ReferenceField1 { get; set; }

        /// <summary>
        /// 备用字段2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reference_field2")]
        public string ReferenceField2 { get; set; }

        /// <summary>
        /// 备用字段3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reference_field3")]
        public string ReferenceField3 { get; set; }

        /// <summary>
        /// 本次交易请求关联的原交易号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("related_message_id")]
        public string RelatedMessageId { get; set; }

        /// <summary>
        /// 业务唯一单据号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_message_id")]
        public string RequestMessageId { get; set; }

        /// <summary>
        /// 请求交易汇率
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requested_rate")]
        public string RequestedRate { get; set; }

        /// <summary>
        /// NDF交割下，实际交割币种的金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_amount")]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// 交割币种
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_ccy")]
        public string SettlementCcy { get; set; }

        /// <summary>
        /// 交易方向
        /// </summary>
        [Newtonsoft.Json.JsonProperty("side")]
        public string Side { get; set; }

        /// <summary>
        /// 汇率上浮滑点 : BP单位，即汇率单位的万分之一。仅在“请求汇率模式”为REQ时有效，在请求汇率/汇率编码对应的汇率的基础上，Side为BUY时上浮滑点，Side为SELL时下浮滑点
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slip_point")]
        public string SlipPoint { get; set; }

        /// <summary>
        /// 客户所在的时区，按照标准时区。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 上层业务应用发起交易时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_timestamp")]
        public string TradeTimestamp { get; set; }

        /// <summary>
        /// 成交模式,按成交价格产生方式，起息日是否明确，交易日期是否明确，交易金额是否部分成交等维度产生的标识组合出的模式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_amount")]
        public string TransactionAmount { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_ccy")]
        public string TransactionCcy { get; set; }

        /// <summary>
        /// 交易币种交割方式,字典：DELIV，NDF。当Client的实际交割货币与交易币种不一致时，送NDF。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_ccy_type")]
        public string TransactionCcyType { get; set; }

        /// <summary>
        /// 交易类型使用。字典：SALE，REFUND，CHARGEBACK，CHARGEBACK_REVERSE，CANCELLATION等
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_type")]
        public string TransactionType { get; set; }

        /// <summary>
        /// 发起交易的用户或商户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 起息日期YYYYMMDD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value_date")]
        public string ValueDate { get; set; }
    }
}
