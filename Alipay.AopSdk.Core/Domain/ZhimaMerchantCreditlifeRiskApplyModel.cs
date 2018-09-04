using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditlifeRiskApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantCreditlifeRiskApplyModel : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 证件号，一般为身份证号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 接入信用套餐所分配的产品码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 手机联系方式
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务流水号，每一笔业务使用一个新的业务流水号，不能重复
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
