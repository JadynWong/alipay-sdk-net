using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JfExportChargeInstModel Data Structure.
    /// </summary>
    [Serializable]
    public class JfExportChargeInstModel : AopObject
    {
        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 出账机构所在城市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 出账机构所在省份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }
    }
}
