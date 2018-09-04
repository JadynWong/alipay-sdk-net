using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoCenRenthousepayTypeList Data Structure.
    /// </summary>
    [Serializable]
    public class EcoCenRenthousepayTypeList : AopObject
    {
        /// <summary>
        /// 集中式房源最小押金
        /// </summary>
        [Newtonsoft.Json.JsonProperty("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 集中式最高价格，支持小数点后面2位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 集中式房源最大押金
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_deposit_amount")]
        public string MaxDepositAmount { get; set; }

        /// <summary>
        /// 其它费用
        /// </summary>
        [XmlArray("other_amount")]
        [XmlArrayItem("eco_renthouse_other_amount")]
        public List<EcoRenthouseOtherAmount> OtherAmount { get; set; }

        /// <summary>
        /// 付款方式（1：付一，2：付二）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 租金
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_amount")]
        public string RoomAmount { get; set; }
    }
}
