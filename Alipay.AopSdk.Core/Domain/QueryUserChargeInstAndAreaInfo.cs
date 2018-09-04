using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryUserChargeInstAndAreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QueryUserChargeInstAndAreaInfo : AopObject
    {
        /// <summary>
        /// 出账机构简称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市编号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 缴费次数
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_count")]
        public string PayCount { get; set; }

        /// <summary>
        /// 最近一次缴费日期
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 子业务类型：   电费:ELECTRIC,水费:WATER,GAS:燃气费    暖气费：HEATING, 有线电视费:CATV
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
