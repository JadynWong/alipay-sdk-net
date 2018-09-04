using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCardConsumeSyncResponse.
    /// </summary>
    public class AlipayMarketingCardConsumeSyncResponse : AopResponse
    {
        /// <summary>
        /// 外部卡号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_card_no")]
        public string ExternalCardNo { get; set; }
    }
}
