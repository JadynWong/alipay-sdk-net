using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicGisGetResponse.
    /// </summary>
    public class AlipayMobilePublicGisGetResponse : AopResponse
    {
        /// <summary>
        /// 精确度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 经纬度所在位置
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 纬度信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 经纬度对应位置所在的省份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }
    }
}
