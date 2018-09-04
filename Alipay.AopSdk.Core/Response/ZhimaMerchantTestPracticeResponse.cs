using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantTestPracticeResponse.
    /// </summary>
    public class ZhimaMerchantTestPracticeResponse : AopResponse
    {
        /// <summary>
        /// xxxx
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dddd")]
        public XXXXsdasdasd Dddd { get; set; }

        /// <summary>
        /// ccc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sss")]
        public string Sss { get; set; }
    }
}
