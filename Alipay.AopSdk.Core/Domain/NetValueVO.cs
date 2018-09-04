using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NetValueVO Data Structure.
    /// </summary>
    [Serializable]
    public class NetValueVO : AopObject
    {
        /// <summary>
        /// 基金单位净值，含4位小数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("net_value")]
        public string NetValue { get; set; }

        /// <summary>
        /// 基金净值日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("net_value_date")]
        public string NetValueDate { get; set; }

        /// <summary>
        /// 七日年化收益率，含5位小数，可以为负
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profit_seven_days")]
        public string ProfitSevenDays { get; set; }

        /// <summary>
        /// 万份收益，含5位小数，可以为负
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profit_ten_thousand")]
        public string ProfitTenThousand { get; set; }
    }
}
