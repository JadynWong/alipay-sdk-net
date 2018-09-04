using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BeaconDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BeaconDeviceInfo : AopObject
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actiontype")]
        public string Actiontype { get; set; }

        /// <summary>
        /// 设备是否可用
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inuse")]
        public bool Inuse { get; set; }

        /// <summary>
        /// 设备说明
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 蓝牙设备关联的模板信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template")]
        public BeaconTemplate Template { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
