using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeInstMode Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeInstMode : AopObject
    {
        /// <summary>
        /// 机构简称(英文名称)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 机构中文名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }
    }
}
