using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbCodeInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class KbCodeInfoVO : AopObject
    {
        /// <summary>
        /// 创建口碑码的批次号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        public long BatchId { get; set; }

        /// <summary>
        /// 口碑码图片(不带背景图)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_url")]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 口碑码创建时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 口碑码ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 口碑码物料图（带背景）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 口碑门店名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 物料模板
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuff_template")]
        public string StuffTemplate { get; set; }

        /// <summary>
        /// 物料模板描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuff_template_desc")]
        public string StuffTemplateDesc { get; set; }

        /// <summary>
        /// 口碑码类型描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuff_type_desc")]
        public string StuffTypeDesc { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_no")]
        public string TableNo { get; set; }
    }
}
