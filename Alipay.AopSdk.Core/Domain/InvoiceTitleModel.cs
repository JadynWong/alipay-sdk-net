using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTitleModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleModel : AopObject
    {
        /// <summary>
        /// 是否为用户设置默认抬头  字段值包括两种情况：  false（非默认）  true（默认抬头）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 支付宝用户登录名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_bank_name")]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 抬头类型  字段值有两种情况抬:  PERSONAL（个人）   CORPORATION（单位）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_type")]
        public string TitleType { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_mobile")]
        public string UserMobile { get; set; }
    }
}
