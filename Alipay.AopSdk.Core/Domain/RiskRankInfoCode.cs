using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskRankInfoCode Data Structure.
    /// </summary>
    [Serializable]
    public class RiskRankInfoCode : AopObject
    {
        /// <summary>
        /// infocode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 此infocode在总的得分中的贡献度
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contribution_degree")]
        public long ContributionDegree { get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_name")]
        public string ModelName { get; set; }
    }
}
