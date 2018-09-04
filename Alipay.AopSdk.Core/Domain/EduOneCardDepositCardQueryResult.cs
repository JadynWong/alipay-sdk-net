using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduOneCardDepositCardQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class EduOneCardDepositCardQueryResult : AopObject
    {
        /// <summary>
        /// 校园一卡通机构代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 校园一卡通机构姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 校园一卡通余额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 校园一卡通姓名
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 校园一卡通卡号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 余额最后更新时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_update_time")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 校园一卡通待领金额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pound_amount")]
        public string PoundAmount { get; set; }
    }
}
