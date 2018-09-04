using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationCancelModel : AopObject
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_no")]
        public string ApplicationNo { get; set; }
    }
}
