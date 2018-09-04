using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingToolMallPointsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolMallPointsSyncModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 业务类型(目前只有点卡)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 渲染截止时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 卡片展示内容，卡片如果没有集的count设置为0，本次交易获取的卡片需设置is_new的值为true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("json_content")]
        public string JsonContent { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// trade|lottery|system，表示为交易|领取礼包|系统调整
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 外部幂等id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// collecting|collectSuccess|finish字段中的一种
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
