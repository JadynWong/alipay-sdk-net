using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTitleOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleOpenModel : AopObject
    {
        /// <summary>
        /// 票面上的购买方地址、电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_address_tel")]
        public string PayerAddressTel { get; set; }

        /// <summary>
        /// 票面上的购买方开户行及账户
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_bank_name_account")]
        public string PayerBankNameAccount { get; set; }

        /// <summary>
        /// 票面上的购买方纳税人识别号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 票面上的购买方名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_name")]
        public string TitleName { get; set; }
    }
}
