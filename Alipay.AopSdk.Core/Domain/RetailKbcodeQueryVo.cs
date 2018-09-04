using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RetailKbcodeQueryVo Data Structure.
    /// </summary>
    [Serializable]
    public class RetailKbcodeQueryVo : AopObject
    {
        /// <summary>
        /// 创建口碑码的批次号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 码的物料模板
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_template")]
        public string CodeTemplate { get; set; }

        /// <summary>
        /// 商户名称，生成码的时候码图片上的提示文案
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_tip")]
        public string CodeTip { get; set; }

        /// <summary>
        /// 口碑码(不带背景)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_url")]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 口碑码创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 口碑码id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 口碑码（带背景）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 促销员信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("salesman")]
        public string Salesman { get; set; }
    }
}
