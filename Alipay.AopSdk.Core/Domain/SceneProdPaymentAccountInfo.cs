using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneProdPaymentAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SceneProdPaymentAccountInfo : AopObject
    {
        /// <summary>
        /// 账号外标，如支付宝登录号,网商银行卡卡号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_ext_no")]
        public string AccountExtNo { get; set; }

        /// <summary>
        /// 金融机构码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_fip_code")]
        public string AccountFipCode { get; set; }

        /// <summary>
        /// 金融机构名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_fip_name")]
        public string AccountFipName { get; set; }

        /// <summary>
        /// 资金账号,支付宝2088开头或银行卡号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账号分类, ALIPAY:支付宝 , CURRENT: 网商银行
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 资金操作金额，单位分
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 账户对公对私类型,P-对私，B-对公
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_card_category")]
        public string BankCardCategory { get; set; }

        /// <summary>
        /// 持卡人姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_holder_name")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// 扩展信息，map格式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 开户行联行号，机构可以通过联行号查询网商查询获取。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_out_code")]
        public string InstOutCode { get; set; }

        /// <summary>
        /// 网商参与者id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商银行角色id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 账单备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_mark")]
        public string PaymentMark { get; set; }
    }
}
