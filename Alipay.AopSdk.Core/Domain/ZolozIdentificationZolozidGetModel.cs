using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozIdentificationZolozidGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationZolozidGetModel : AopObject
    {
        /// <summary>
        /// get region
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// bizId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extern_params")]
        public string ExternParams { get; set; }

        /// <summary>
        /// json字符串
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zcif_params")]
        public string ZcifParams { get; set; }
    }
}
