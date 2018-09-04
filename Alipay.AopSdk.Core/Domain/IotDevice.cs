using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotDevice Data Structure.
    /// </summary>
    [Serializable]
    public class IotDevice : AopObject
    {
        /// <summary>
        /// 蓝牙MAC地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bluetooth_mac")]
        public string BluetoothMac { get; set; }

        /// <summary>
        /// 设备控制面板地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("control_url")]
        public string ControlUrl { get; set; }

        /// <summary>
        /// 协议服务商用于唯一标识该设备的设备id(协议服务商定义)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 协议服务商用于唯一标识一个设备型号的型号id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备WIFI的MAC地址
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wifi_mac")]
        public string WifiMac { get; set; }
    }
}
