using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel : AopObject
    {
        /// <summary>
        /// yufaa
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yufaa")]
        public string Yufaa { get; set; }
    }
}
