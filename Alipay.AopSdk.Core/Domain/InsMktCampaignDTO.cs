using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsMktCampaignDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCampaignDTO : AopObject
    {
        /// <summary>
        /// 保险营销活动id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 活动奖品发行量
        /// </summary>
        [Newtonsoft.Json.JsonProperty("circulation")]
        public long Circulation { get; set; }

        /// <summary>
        /// 活动权益配置
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_config")]
        public InsMktCouponConfigDTO CouponConfig { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动备注
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 活动标的列表
        /// </summary>
        [XmlArray("mkt_objects")]
        [XmlArrayItem("ins_mkt_object_d_t_o")]
        public List<InsMktObjectDTO> MktObjects { get; set; }

        /// <summary>
        /// 保险营销活动名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 发奖金额算法
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_algorithm")]
        public string SendAlgorithm { get; set; }

        /// <summary>
        /// 发奖规则类型：  1. 基于账户做发奖控制  2. 基于身份证做发奖控制  3. 基于业务单号做发奖控制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_frqnc_type")]
        public long SendFrqncType { get; set; }

        /// <summary>
        /// 发奖规则值，频次为3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_frqnc_value")]
        public long SendFrqncValue { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态：  5：活动已发布，待生效  6：活动已生效  7：活动已失效  8：活动已下线
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        public long Status { get; set; }
    }
}
