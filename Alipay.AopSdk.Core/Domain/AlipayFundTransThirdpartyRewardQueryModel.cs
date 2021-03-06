using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransThirdpartyRewardQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，接入时找业务方分配
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 付款方支付宝UserId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 打赏单据号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_no")]
        public string TransferNo { get; set; }
    }
}
