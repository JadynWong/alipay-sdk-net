using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthContractMerchantSignModel : AopObject
    {
        /// <summary>
        /// 商家银行账号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// json串格式的扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 费率模型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_value")]
        public FeeValue FeeValue { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 生效失效策略模型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_strategy")]
        public ValidStrategy ValidStrategy { get; set; }
    }
}
