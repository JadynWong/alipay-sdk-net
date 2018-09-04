using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneProductSignConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductSignConfirmModel : AopObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 支付宝会员ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
