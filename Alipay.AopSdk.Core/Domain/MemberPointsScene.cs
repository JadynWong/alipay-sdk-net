using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberPointsScene Data Structure.
    /// </summary>
    [Serializable]
    public class MemberPointsScene : AopObject
    {
        /// <summary>
        /// 用户兑换的内容。  type：VOUCHER(券)  type为券时，ids返回的是券ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exchange_info")]
        public PointsExchangeInfo ExchangeInfo { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kb_trade_no")]
        public string KbTradeNo { get; set; }

        /// <summary>
        /// 综合体ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 变化时间：格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 积分变化类型  ADD：增加  DECR：减少  REVERSAL：冲正
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oper_type")]
        public string OperType { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 积分余额
        /// </summary>
        [Newtonsoft.Json.JsonProperty("points_balance")]
        public long PointsBalance { get; set; }
    }
}
