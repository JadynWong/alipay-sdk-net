using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsLiability Data Structure.
    /// </summary>
    [Serializable]
    public class InsLiability : AopObject
    {
        /// <summary>
        /// 保额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 是否可以编辑,0-可选; 1-不可选,不支持; 2-必选,目前不打开
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disabled")]
        public string Disabled { get; set; }

        /// <summary>
        /// 不计免赔 0，1，2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iop")]
        public string Iop { get; set; }

        /// <summary>
        /// 不计免赔保费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iop_premium")]
        public string IopPremium { get; set; }

        /// <summary>
        /// 责任描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("liability_desc")]
        public string LiabilityDesc { get; set; }

        /// <summary>
        /// 责任名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("liability_name")]
        public string LiabilityName { get; set; }

        /// <summary>
        /// 责任编码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("liability_no")]
        public string LiabilityNo { get; set; }

        /// <summary>
        /// 责任保费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("liability_premium")]
        public string LiabilityPremium { get; set; }

        /// <summary>
        /// options
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("ins_option")]
        public List<InsOption> Options { get; set; }

        /// <summary>
        /// 责任保费
        /// </summary>
        [Newtonsoft.Json.JsonProperty("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_insured")]
        public InsSumInsured SumInsured { get; set; }
    }
}
