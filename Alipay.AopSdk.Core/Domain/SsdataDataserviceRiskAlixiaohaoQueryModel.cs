using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAlixiaohaoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskAlixiaohaoQueryModel : AopObject
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile_no")]
        public string MobileNo { get; set; }
    }
}
