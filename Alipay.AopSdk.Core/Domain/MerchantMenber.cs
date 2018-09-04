using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantMenber Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantMenber : AopObject
    {
        /// <summary>
        /// 生日 yyyy-MM-dd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cell")]
        public string Cell { get; set; }

        /// <summary>
        /// 性别（男：MALE；女：FEMALE）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gende")]
        public string Gende { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
    }
}
