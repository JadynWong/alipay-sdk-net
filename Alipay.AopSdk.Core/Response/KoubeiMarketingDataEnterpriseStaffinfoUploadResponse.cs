using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataEnterpriseStaffinfoUploadResponse.
    /// </summary>
    public class KoubeiMarketingDataEnterpriseStaffinfoUploadResponse : AopResponse
    {
        /// <summary>
        /// 人群ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crowd_id")]
        public string CrowdId { get; set; }
    }
}
