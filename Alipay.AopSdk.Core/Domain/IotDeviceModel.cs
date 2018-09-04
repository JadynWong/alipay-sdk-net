using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotDeviceModel Data Structure.
    /// </summary>
    [Serializable]
    public class IotDeviceModel : AopObject
    {
        /// <summary>
        /// 该型号所属类目的类目id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 型号支持的配网链接类型, 取值可为WiFi，BlueTooth
        /// </summary>
        [XmlArray("connection_types")]
        [XmlArrayItem("string")]
        public List<string> ConnectionTypes { get; set; }

        /// <summary>
        /// 配网链接地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connection_url")]
        public string ConnectionUrl { get; set; }

        /// <summary>
        /// 关于型号的描述信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("decription")]
        public string Decription { get; set; }

        /// <summary>
        /// 型号的图标图片地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 协议服务商用于唯一标识一个设备型号的型号id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 设备型号的名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_name")]
        public string ModelName { get; set; }
    }
}
