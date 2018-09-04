using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MachineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MachineInfo : AopObject
    {
        /// <summary>
        /// 设备数量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("machine_count")]
        public long MachineCount { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("machine_model")]
        public string MachineModel { get; set; }

        /// <summary>
        /// 设备类型，由商户定义
        /// </summary>
        [Newtonsoft.Json.JsonProperty("machine_type")]
        public string MachineType { get; set; }
    }
}
