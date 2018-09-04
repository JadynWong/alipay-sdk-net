using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthContractMerchantUnsignModel : AopObject
    {
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
    }
}
