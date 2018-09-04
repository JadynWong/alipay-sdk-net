using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTitleApplyOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleApplyOpenModel : AopObject
    {
        /// <summary>
        /// 购买方地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 开户行账户
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_bank_account")]
        public string PayerBankAccount { get; set; }

        /// <summary>
        /// 购买方开户银行
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购买方纳税人识别号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_tel")]
        public string PayerTel { get; set; }

        /// <summary>
        /// 发票抬头名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_name")]
        public string TitleName { get; set; }
    }
}
