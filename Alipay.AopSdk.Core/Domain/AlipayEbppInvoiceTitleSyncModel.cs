using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleSyncModel : AopObject
    {
        /// <summary>
        /// 开户银行账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_bank_name")]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_mobile")]
        public string UserMobile { get; set; }
    }
}
