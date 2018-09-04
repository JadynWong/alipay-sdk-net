using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExproductconfResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ExproductconfResponse : AopObject
    {
        /// <summary>
        /// 出账机构
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chargeinst_name")]
        public string ChargeinstName { get; set; }

        /// <summary>
        /// 销账机构
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 销账机构中文名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chargeoffinst_name")]
        public string ChargeoffinstName { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 产品状态
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }
    }
}
