using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EquipmentAuthRemoveQueryBypageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EquipmentAuthRemoveQueryBypageDTO : AopObject
    {
        /// <summary>
        /// 机具编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 解绑时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unbind_time")]
        public string UnbindTime { get; set; }
    }
}
