using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsProdCoverage Data Structure.
    /// </summary>
    [Serializable]
    public class InsProdCoverage : AopObject
    {
        /// <summary>
        /// 险种描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverage_desc")]
        public string CoverageDesc { get; set; }

        /// <summary>
        /// 险种名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverage_name")]
        public string CoverageName { get; set; }

        /// <summary>
        /// 险种编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverage_no")]
        public string CoverageNo { get; set; }

        /// <summary>
        /// 是否定期险种
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_fixed_period")]
        public bool IsFixedPeriod { get; set; }

        /// <summary>
        /// 险种责任列表
        /// </summary>
        [XmlArray("liabilities")]
        [XmlArrayItem("ins_liability")]
        public List<InsLiability> Liabilities { get; set; }

        /// <summary>
        /// 可用的保障期限列表;约定“1D”代表一天，“1M”代表一个月,"1Y"代表一年
        /// </summary>
        [XmlArray("periods")]
        [XmlArrayItem("string")]
        public List<string> Periods { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_insured")]
        public InsSumInsured SumInsured { get; set; }
    }
}
