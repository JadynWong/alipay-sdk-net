using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarCarlibInfoPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCarlibInfoPushModel : AopObject
    {
        /// <summary>
        /// 品牌
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// 发动机型号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// 销售名字
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marker")]
        public string Marker { get; set; }

        /// <summary>
        /// 生产年份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_year")]
        public string ProdYear { get; set; }

        /// <summary>
        /// 车系
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serie")]
        public string Serie { get; set; }

        /// <summary>
        /// 车款
        /// </summary>
        [Newtonsoft.Json.JsonProperty("style")]
        public string Style { get; set; }
    }
}
